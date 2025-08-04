using AutoMapper;
using BooklyBookStoreApp.Application.Abstractions;
using BooklyBookStoreApp.Application.Services;
using BooklyBookStoreApp.Domain.Entitites;
using BooklyBookStoreApp.Domain.Repositories;
using Microsoft.AspNetCore.Identity;

namespace BooklyBookStoreApp.Persistence.Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<IBookService> _bookService;
    private readonly Lazy<ICategoryService> _categoryService;
    private readonly Lazy<IUserService> _userService;
    private readonly Lazy<IFavoriteService> _favoriteService;
    private readonly Lazy<IBasketService> _basketService;
    public ServiceManager(IMapper mapper, IRepositoryManager manager,UserManager<User> userManager,IJwtProvider jwtProvider)
    {
        _bookService = new Lazy<IBookService>(() => new BookService(mapper,manager));
        _categoryService = new Lazy<ICategoryService>(() => new CategoryService(manager,mapper));
        _userService = new Lazy<IUserService>(() => new UserService(userManager,mapper,jwtProvider));
        _favoriteService = new Lazy<IFavoriteService>(() => new FavoriteService(manager,mapper));
        _basketService = new Lazy<IBasketService>(() => new BasketService(manager,mapper));
    }

    public IBookService BookService => _bookService.Value;
    public ICategoryService CategoryService => _categoryService.Value;
    public IUserService UserService => _userService.Value;
    public IFavoriteService FavoriteService => _favoriteService.Value;
    public IBasketService BasketService => _basketService.Value;

}
