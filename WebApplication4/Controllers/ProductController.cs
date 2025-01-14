﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication4.Pages;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        // Створюємо декілька об'єктів Product
        var products = new List<Product>
        {
            new Product { ID = 1, Name = "Product 1", Price = 10.99m, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = 19.99m, CreatedDate = DateTime.Now.AddDays(-1) },
            new Product { ID = 3, Name = "Product 3", Price = 5.99m, CreatedDate = DateTime.Now.AddDays(-2) }
        };

        return View(products);
    }
}
