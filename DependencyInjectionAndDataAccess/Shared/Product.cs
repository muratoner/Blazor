using System;

namespace DependencyInjectionAndDataAccess.Shared
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Rating { get; set; }

        public decimal Price { get; set; }
    }
}
