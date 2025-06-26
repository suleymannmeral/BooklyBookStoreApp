using BooklyBookStoreApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooklyBookStoreApp.Presentation.Controllers;


[ApiController]
[Route("api/[controller]")]
public class BookController:ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("GetAllBooks")]
    public async Task<IActionResult> GetAllBooks()
    {
        var result = await _bookService.GetAllBooksAsync(false);
        return Ok(result);
    }
}
