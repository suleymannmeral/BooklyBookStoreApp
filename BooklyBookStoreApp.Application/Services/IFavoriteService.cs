using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.DTOs.Favorites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Application.Services
{
    public interface IFavoriteService
    {
        Task<FavoriteDto> CreateFavoriteAsync(CreateFavoriteDto createBookDto);

    }
}
