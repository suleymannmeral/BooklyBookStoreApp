

using BooklyBookStoreApp.Application.DTOs.UserDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Presentation.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BooklyBookStoreApp.Presentation.Controllers;

public class UsersController : BaseApiController
{
    public UsersController(IServiceManager manager) : base(manager)
    {
    }

    [HttpPost]
    public async Task<IActionResult>RegisterUser(RegisterUserDto request)
    {
       await  _manager.UserService.RegisterAsync(request);
        return Ok("User registered successfully");

    }
}
