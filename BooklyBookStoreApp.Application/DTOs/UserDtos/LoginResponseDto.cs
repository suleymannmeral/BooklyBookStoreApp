

namespace BooklyBookStoreApp.Application.DTOs.UserDtos;

public record LoginResponseDto(
 string Token,
 DateTime ExpireDate,
 string Id
);
