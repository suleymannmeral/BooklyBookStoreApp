using Microsoft.AspNetCore.Identity;

namespace BooklyBookStoreApp.Domain.Entitites
{
    public class AppUser:IdentityUser
    {
        public string? Adress {  get; set; } 
        public string? City {  get; set; } 
        public string? District {  get; set; } 

        public ICollection<Order> Orders { get; set; }= new List<Order>();
        public ICollection<Favorites> Favorites { get; set; }= new List<Favorites>();
        public ICollection<BookComment> BookComments { get; set; } = new List<BookComment>();


    }
}
