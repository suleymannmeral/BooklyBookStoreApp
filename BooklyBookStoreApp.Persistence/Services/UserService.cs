using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.UserDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using Microsoft.AspNetCore.Identity;

namespace BooklyBookStoreApp.Persistence.Services;

public class UserService : IUserService
{
    private readonly UserManager<User>_userManager;
    private readonly IMapper _mapper;

    public UserService(UserManager<User> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public Task<LoginResponseDto> LoginAsync(LoginUserDto registerUserDto)
    {
        throw new NotImplementedException();
    }

    public async Task RegisterAsync(RegisterUserDto request)
    {
        User user = _mapper.Map<User>(request);
        IdentityResult result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        { 
            throw new Exception(result.Errors.First().Description);
        }
    }
}
