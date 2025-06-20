

namespace BooklyBookStoreApp.Domain.Entitites
{
    public class Order
    {
        public int Id { get; set; }

        //AppUser ilişkisi
        public string AppUserID { get; set; }  // Foreign Key
        public AppUser AppUser { get; set; }



        // Order Details
        public ICollection<OrderBook> OrderBooks { get; set; } = new List<OrderBook>();
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }


    }
}
