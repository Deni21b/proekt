using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using HoneyShop.Models;

namespace HoneyShop.Controllers
{
    // Контролер за страницата с всички продукти
    public class ProductsController : Controller
    {
        // Симулираме база данни с List<Product>
        private List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Акациев мед",     Description = "Нежен бял мед с деликатен цветен аромат. Не кристализира дълго. Идеален за бебета над 1 год.",    Price = 12.90m, Weight = "500г", ImageClass = "acacia",    Emoji = "🍯", Badge = "Хит",     IsAvailable = true  },
                new Product { Id = 2, Name = "Липов мед",       Description = "Класически ароматен мед с успокояващо действие. Перфектен за вечерен чай.",                       Price = 10.50m, Weight = "500г", ImageClass = "linden",    Emoji = "🌿", Badge = "Любимец", IsAvailable = true  },
                new Product { Id = 3, Name = "Планински мед",   Description = "Тъмен богат мед от дива планинска флора – мащерка, жълт кантарион, горска малина.",              Price = 15.00m, Weight = "500г", ImageClass = "mountain",  Emoji = "⛰️", Badge = "Премиум",  IsAvailable = true  },
                new Product { Id = 4, Name = "Слънчогледов мед",Description = "Жълт, бързо кристализиращ мед с наситен вкус и висока концентрация на глюкоза.",                  Price = 8.50m,  Weight = "500г", ImageClass = "sunflower",  Emoji = "🌻", Badge = "Нов",     IsAvailable = true  },
                new Product { Id = 5, Name = "Горски мед",      Description = "Тъмен мед от иглолистни гори. Богат на минерали и ензими. Подходящ за имунната система.",        Price = 18.00m, Weight = "500г", ImageClass = "forest",    Emoji = "🌲", Badge = "Рядък",   IsAvailable = true  },
                new Product { Id = 6, Name = "Кориандров мед",  Description = "Рядък и ароматен мед с леко пикантен послевкус. Събиран в ограничени количества.",               Price = 16.50m, Weight = "500г", ImageClass = "coriander", Emoji = "🌸", Badge = "Лимитиран",IsAvailable = false }
            };

            return products;
        }

        // GET: Products/Index - Всички продукти
        public ActionResult Index()
        {
            ViewBag.Title = "Нашите продукти";
            List<Product> products = GetAllProducts();
            return View(products);
        }

        // GET: Products/Details/5 - Детайли за продукт
        public ActionResult Details(int id)
        {
            List<Product> products = GetAllProducts();

            // Намираме продукта по Id
            Product product = null;
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    product = p;
                    break;
                }
            }

            if (product == null)
            {
                return HttpNotFound(); // 404 ако не е намерен
            }

            ViewBag.Title = product.Name;
            return View(product);
        }
    }
}
