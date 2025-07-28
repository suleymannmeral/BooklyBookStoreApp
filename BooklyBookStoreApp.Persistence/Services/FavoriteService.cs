using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.Favorites;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;

namespace BooklyBookStoreApp.Persistence.Services;

public sealed class FavoriteService(IRepositoryManager manager, IMapper mapper) : IFavoriteService
{


    public async Task<FavoriteDto> CreateFavoriteAsync(CreateFavoriteDto createFavoriteDto)
    {
        var favorite = mapper.Map<Favorites>(createFavoriteDto);
        manager.Favorite.Create(favorite);
        await manager.Save();
        return  mapper.Map<FavoriteDto>(favorite);

    }
}
