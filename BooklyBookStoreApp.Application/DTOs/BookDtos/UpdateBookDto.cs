namespace BooklyBookStoreApp.Application.DTOs.BookDtos;

public record UpdateBookDto(
  int id,
 string Title,
 string? Description,
 decimal Price,
 string PictureURl,
 string? Author,
 int CategoryID
 );
