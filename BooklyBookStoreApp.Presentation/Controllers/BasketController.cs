using BooklyBookStoreApp.Application.DTOs.BasketDtos;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Presentation.Abstractions;
using Microsoft.AspNetCore.Mvc;


namespace BooklyBookStoreApp.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BasketController : ControllerBase
{
    private readonly IBasketService _basketService;

    public BasketController(IBasketService basketService)
    {
        _basketService = basketService;
    }

    [HttpGet("basket-items/{userId}")]
    public async Task<IActionResult> GetBasketItems(string userId)
    {
        var basket = await _basketService.GetBasketAsync(userId);
        return Ok(basket);
             
    }
    [HttpPost("add")]
    public async Task<IActionResult> AddToBasket([FromBody] AddBasketItemDto dto)
    {
        var userId = "ee7df6bf-5e2c-4a42-81e3-18dffb65d09f";
        await _basketService.AddItemToBasketAsync(userId, dto);
        return Ok("Sepete eklendi");
    }

    [HttpDelete("clear-basket/{userid}")]
    public async Task<IActionResult>ClearBasket(string userid)
    {
         await _basketService.ClearBasketAsync(userid);
        return Ok("Delete Successfully");

    }


}
