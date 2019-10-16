using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Network.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Network.Controllers
{
    public class LoggingController : Controller
    {
        private readonly ILogger<LoggingController> logger;

        public LoggingController(ILogger<LoggingController> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        [HttpPost]
        public IActionResult LogIn()
        {
            try
            {
                //ShopContext sc = new ShopContext();
                //sc.Products.Add(new Product
                //{
                //    Description = "Vending machine",
                //    Price = 115
                //});
                //sc.Storages.Add(new ItemsStorage
                //{
                //    AmountAvailable = 50,
                //    OnSale = false,
                //    //ProductRef = new Product
                //});
                //sc.Purchases.Add(new Purchase
                //{
                //    PurchaseDate = new DateTime(2012, 12, 12),
                //    //Products =
                //    //PurchasedBy = 
                //});
                //sc.Accounts.Add(new Account
                //{
                //    FirstName = "Pavlo",
                //    LastName = "Picasso",
                //    Age = 22,
                //    Money = 400,
                //    Points = 25,
                //    //Products = sc.Products.Take(1).ToList()
                //});
                //sc.SaveChanges();
                //sc.Dispose();
                return View();
            }
            catch (Exception e)
            {
                logger.LogError(e, "Could not connect :( ");
                return View();
            }
        }
    }
}
