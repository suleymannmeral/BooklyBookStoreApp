using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Application.DTOs.BookDtos
{
    public record BookDto(
     string Title,
     string? Description,
     decimal Price,
     string PictureURl,
     string? Author,
     int CategoryID
     );

}
