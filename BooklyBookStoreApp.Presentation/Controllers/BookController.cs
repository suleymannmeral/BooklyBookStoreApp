using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Presentation.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BooklyBookStoreApp.Presentation.Controllers;


public class BooksController:BaseApiController
{
    public BooksController(IServiceManager manager) : base(manager)
    {
    }

    [HttpGet("GetAllBooksWithCategoryName")]
    public async Task<IActionResult> GetAllBooksWithCategoryName()
    {
        var result = await _manager.BookService.GetAllBooksWithCategoryNameAsync(false);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> CreateBook([FromBody] CreateBookDto bookDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var result = await _manager.BookService.CreateBookAsync(bookDto);
        return Ok(new
        {
            message = "Book has been added successfully",
            data = result
        });
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetOneBookWithCategoryName(int id)
    {
        var result = await _manager.BookService.GetOneBookByIdWithCategoryNameAsync(id,false);
        return Ok(result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook([FromRoute(Name="id")] int id)
    {
        await _manager.BookService.DeleteBookAsync(id,false);
        return Ok("Book has been deleted succesfully");
    }

    [HttpPut("{id:int}")]

    public async Task<IActionResult> UpdateBook([FromRoute(Name = "id")] int id, [FromBody] UpdateBookDto bookDto)
    {

        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        await _manager.BookService.UpdateBookAsync(id,bookDto,false);
        return Ok("Book has been updated successfully");
    }
}
