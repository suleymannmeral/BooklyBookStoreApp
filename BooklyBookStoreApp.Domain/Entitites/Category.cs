﻿
namespace BooklyBookStoreApp.Domain.Entitites
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public ICollection<Book>Books { get; set; }
    }
}
