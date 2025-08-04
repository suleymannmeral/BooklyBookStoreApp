

using BooklyBookStoreApp.Application.Abstractions;
using BooklyBookStoreApp.Application.DTOs.UserDtos;
using BooklyBookStoreApp.Domain.Entitites;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Infrastructure.Authentication;

public sealed class JwtProvider : IJwtProvider
{
    private readonly JwtOptions _jwtOptions;
    private readonly UserManager<User> _user;

    public JwtProvider(IOptions<JwtOptions> jwtOptions, UserManager<User> user)
    {
        _jwtOptions = jwtOptions.Value;
        _user = user;
    }
    public async Task<LoginResponseDto> CreateTokenAsync(User user)
    {
        // 1️⃣ Kullanıcı claim'leri oluştur
        var claims = new Claim[]
        {
     new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),

        new Claim(ClaimTypes.Email, user.Email),
        new Claim(JwtRegisteredClaimNames.Name, user.UserName),
        new Claim("NameLastName", user.NameSurname),
        };

        // 2️⃣ Token süresini belirle
        DateTime expires = DateTime.Now.AddHours(1);

        // 3️⃣ JWT token'ı oluştur (claim'leri eklemeyi unutma!)
        JwtSecurityToken jwtSecurityToken = new(
            issuer: _jwtOptions.Issuer,
            audience: _jwtOptions.Audience,
            claims: claims, //
            notBefore: DateTime.Now,
            expires: expires,
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)),
                SecurityAlgorithms.HmacSha256
            )
        );

        // 4️⃣ Token'ı string'e çevir
        string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

        // 5️⃣ Refresh Token oluştur
        string refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        user.RefreshToken = refreshToken;
        user.RefreshTokenExpires = expires.AddMinutes(15);

        // 6️⃣ Kullanıcıya refresh token'ı kaydet
        await _user.UpdateAsync(user);

        // 7️⃣ DTO ile cevap dön
        return new LoginResponseDto(
            token,
            refreshToken,
            user.RefreshTokenExpires,
            user.Id
        );
    }

}
