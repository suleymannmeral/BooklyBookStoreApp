using BooklyBookStoreApp.Application.DTOs.CategoryDtos;
using BooklyBookStoreApp.Application.DTOs.Favorites;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Presentation.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Presentation.Controllers
{
    public sealed class FavoritesController : BaseApiController
    {
        public FavoritesController(IServiceManager manager) : base(manager)
        {
        }
        [HttpPost]
        public async Task<IActionResult> CreateFavorite([FromBody] CreateFavoriteDto request)
        {
            var result = await _manager.FavoriteService.CreateFavoriteAsync(request);
            return Ok( new
            {
                success = true,
                message = "Favorites has been added successfully",
                data = result
            });
        }

    }
}
