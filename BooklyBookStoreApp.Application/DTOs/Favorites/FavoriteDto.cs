namespace BooklyBookStoreApp.Application.DTOs.Favorites;

public record FavoriteDto
{
    public FavoriteDto()
    {
    }

    public  int Id { get; set; }
    public  string BookName { get; set; }
}

