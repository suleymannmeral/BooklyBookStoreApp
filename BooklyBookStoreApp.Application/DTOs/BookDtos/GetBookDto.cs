
namespace BooklyBookStoreApp.Application.DTOs.BookDtos;

public record GetBookDto(
 int Id,
string Title,
string? Description,
decimal Price,
string PictureURl,
string? Author,
string CategoryName
);
