
namespace BooklyBookStoreApp.Domain.Entitites
{
    public class Favorites
    {
        public int Id { get; set; }
        //AppUser ilişkisi
        public string AppUserID { get; set; }  // Foreign Key
        public AppUser AppUser { get; set; }

        // Kitap İlişkisi
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime CreatedAt  { get; set; }
    }
}
