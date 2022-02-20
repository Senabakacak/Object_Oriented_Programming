using Abstraction.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Businiess.Data
{
    public static class FakeData
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category{Id=Guid.NewGuid(), Name="Boxing Gloves",Description="Best boxing gloves are Everlast"},
            new Category { Id= Guid.NewGuid(), Name = "Hand Wraps", Description = "Best hand wraps are Everlast" },
            new Category { Id= Guid.NewGuid(), Name = "Punching Bags", Description = "Best punching bags are Everlast" }
        };

        public static List<Product> Products = new List<Product>()
        {
            new Product { Id = 1, Name = "Pro Boxing GLoves", Description = "Best boxing gloves", Price = 12.3M, Stock = 34 },
            new Product { Id = 2, Name = "Pro Hands Wrap", Description = "Best hands wrap", Price = 1.3M, Stock = 12 },
            new Product { Id = 3, Name = "Pro Punching Bags", Description = "Best punching bags", Price = 34.3M, Stock = 56 }
        };
    }
}
