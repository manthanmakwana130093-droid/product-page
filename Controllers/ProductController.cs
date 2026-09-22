using System.Collections.Generic;
using System.Web.Mvc;
using project6.Models;

namespace project6.Controllers
{
    public class ProductController : Controller
    {
        private static List<products> productsList = new List<products>
        {
            new products
            {
                id = 1,
                name = "Iphone 17",
                description = "New Model in 2026",
                price = "75000",   // use decimal, not string
                quantity = 5,
                category = "Mobile",
                imageurl = "https://www.idropnews.com/wp-content/uploads/2025/09/Sept-2025-Awe-Dropping-iPhone-17-8-1000x600.jpeg"
            },
            new products
            {
                id = 2,
                name = "HP Laptop",
                description = "Basic HP Laptop",
                price ="45000",
                quantity = 3,
                category = "Laptop",
                imageurl = "https://tse3.mm.bing.net/th/id/OIP.91W-LxIDfqnzBEB4BJfXewHaGS"
            },
            new products
            {
                id = 3,
                name = "Iphone 17 512 GB",
                description = "New Model in 2026",
                price = "85000",
                quantity = 5,
                category = "Mobile",
                imageurl = "https://www.idropnews.com/wp-content/uploads/2025/09/Sept-2025-Awe-Dropping-iPhone-17-8-1000x600.jpeg"
            }
        };
        public ActionResult Details(int id)
        {
            var product = productsList.Find(p => p.id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
        // GET: Product
        public ActionResult Index()

        {
            // Pass the list to the view
            return View(productsList);
        }
    }
}
