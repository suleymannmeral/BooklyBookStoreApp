using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using Microsoft.AspNetCore.Mvc;
namespace BooklyBookStoreApp.Presentation.Controllers;


[ApiController]
[Route("api/[controller]")]
public sealed class TestController:ControllerBase
{

   private readonly IBookService _bookService;


    public TestController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookDto createBookDto)
    {
       await _bookService.CreateAsync(createBookDto);
        return Ok(createBookDto);
        
    }
   

}
