using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Application.DTOs.CategoryDtos;
using BooklyBookStoreApp.Domain.Entitites;

namespace BooklyBookStoreApp.Persistence.Mappings;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookDto, Book>().ReverseMap();

        CreateMap<UpdateBookDto, Book>().ReverseMap();
        CreateMap<BookDto, Book>().ReverseMap();

        CreateMap<GetOneBookWithCategoryNameDto, Book>().ReverseMap()
             .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        CreateMap<GetAllBooksWithCategoryNameDto, Book>().ReverseMap()
             .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        CreateMap<CreateCategoryDto, Category>().ReverseMap();
        CreateMap<CategoryDto, Category>().ReverseMap();
        CreateMap<GetOneCategoryByIdDto, CategoryDto>().ReverseMap();
        CreateMap<GetAllCategoriesDto, Category>().ReverseMap();
        CreateMap<UpdateCategoryDto, Category>().ReverseMap();



    }
}
