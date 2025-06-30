using BooklyBookStoreApp.Application.DTOs.BookDtos;
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
    [HttpGet("GetBookByID")]
    public async Task<IActionResult> GetBookByID(int id)
    {
        var result = await _bookService.GetOneBookByIdAsync(id,false);
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook([FromRoute(Name="id")] int id)
    {
        await _bookService.DeleteBookAsync(id,false);
        return Ok("Book has been deleted succesfully");
    }

    [HttpPut("{id:int}")]

    public async Task<IActionResult> UpdateBook([FromRoute(Name = "id")] int id, [FromBody] UpdateBookDto bookDto)
    {
        await _bookService.UpdateBookAsync(id,bookDto,false);
        return Ok("Book has been updated successfully");
    }
}
