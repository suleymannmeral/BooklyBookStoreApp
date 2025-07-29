using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.DTOs.Favorites;
using BooklyBookStoreApp.Application.DTOs.FavoritesDtos;

namespace BooklyBookStoreApp.Application.Services;

public interface IFavoriteService
{
    Task<FavoriteDto> CreateFavoriteAsync(CreateFavoriteDto createBookDto);
    Task<IEnumerable<GetAllFavoritesByUsernameWithBookDetailsDto>> GetAllFavoritesByUserIdWithBookDetailsAsync(string userid);


}
