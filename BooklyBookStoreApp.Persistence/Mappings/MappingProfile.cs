using AutoMapper;
using BooklyBookStoreApp.Application.DTOs.BookDtos;
using BooklyBookStoreApp.Domain.Entitites;

namespace BooklyBookStoreApp.Persistence.Mappings;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBookDto, Book>().ReverseMap();

    }
}
