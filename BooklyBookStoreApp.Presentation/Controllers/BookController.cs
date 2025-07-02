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

    [HttpGet("GetAllBooksWithCategoryName")]
    public async Task<IActionResult> GetAllBooksWithCategoryName()
    {
        var result = await _bookService.GetAllBooksWithCategoryNameAsync(false);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> CreateBook([FromBody] CreateBookDto bookDto)
    {
        var result = await _bookService.CreateBookAsync(bookDto);
        return Ok(new
        {
            message = "Book has been added successfully",
            data = result
        });
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetOneBookWithCategoryName(int id)
    {
        var result = await _bookService.GetOneBookByIdWithCategoryNameAsync(id,false);
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
