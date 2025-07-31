
namespace BooklyBookStoreApp.Application.DTOs.BasketDtos;

public class BasketItemDto
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
