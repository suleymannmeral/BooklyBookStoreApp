namespace BooklyBookStoreApp.Application.DTOs.BookDtos;

public record BookDto(
 string Title,
 string? Description,
 decimal Price,
 string PictureURl,
 string? Author,
 int CategoryID
 );
