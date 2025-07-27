using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.DTOs.CategoryDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Presentation.Abstractions;
using BooklyBookStoreApp.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;


namespace BooklyBookStoreApp.Presentation.Controllers;

public sealed class CategoriesController : BaseApiController
{
    public CategoriesController(IServiceManager manager) : base(manager)
    {
    }

    [ServiceFilter(typeof(ValidationFilterAttribute))]
    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
    {


        var result = await _manager.CategoryService.CreateCategoryAsync(createCategoryDto);
        return CreatedAtAction(nameof(GetOneCategoryById), new
        {
            success = true,
            message = "Category has been added successfully",
            data = result
        });
    }

    [HttpGet("{id:int}")]
    [ServiceFilter(typeof(ValidationFilterAttribute))]

    public async Task<IActionResult> GetOneCategoryById(int id)
    {
        var result = await _manager.CategoryService.GetOneCategoryByIdAsync(id, false);
        return Ok(result);
    }
}
