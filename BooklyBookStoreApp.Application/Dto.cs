using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyBookStoreApp.Application
{
    public class Dto
    {
       
            public string Title { get; set; }
            public string? Description { get; set; }
            public decimal Price { get; set; }
            public string? PictureURl { get; set; }
            public string? Author { get; set; }
            public int CategoryID { get; set; }
        
    }
}
