using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Domain.Entitites
{
    public class Basket
    {
        public int Id { get; set; }

        public string AppUserID { get; set; }  // Foreign Key
        public AppUser AppUser { get; set; }

        public ICollection<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
