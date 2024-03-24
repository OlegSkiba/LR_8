using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace WebApplication4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            // Створюємо декілька об'єктів Product
            Products = new List<Product>
            {
                new Product { ID = 1, Name = "CPU", Price = 10.99m, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Graphics card", Price = 19.99m, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 3, Name = "RAM memory", Price = 5.99m, CreatedDate = DateTime.Now.AddDays(-2) }
            };
        }
    }

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
