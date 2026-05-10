using System;
using System.Collections.Generic;
using System.Web.Mvc;
using HoneyShop.Models;

namespace HoneyShop.Controllers
{
    // Контролер за началната страница, За нас и Контакти
    public class HomeController : Controller
    {
        // GET: Home/Index - Начална страница
        public ActionResult Index()
        {
            ViewBag.Title = "Начало";

            // Примерни 3 продукта за началната страница
            List<Product> featuredProducts = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Акациев мед",
                    Description = "Нежен, бял мед с деликатен вкус. Не се захаросва дълго.",
                    Price = 12.90m,
                    Weight = "500г",
                    ImageClass = "acacia",
                    Emoji = "🍯",
                    Badge = "Хит"
                },
                new Product
                {
                    Id = 2,
                    Name = "Липов мед",
                    Description = "Ароматен мед с успокояващо действие. Идеален за чай.",
                    Price = 10.50m,
                    Weight = "500г",
                    ImageClass = "linden",
                    Emoji = "🌿",
                    Badge = "Любимец"
                },
                new Product
                {
                    Id = 3,
                    Name = "Планински мед",
                    Description = "Тъмен мед от дива планинска флора. Богат на минерали.",
                    Price = 15.00m,
                    Weight = "500г",
                    ImageClass = "mountain",
                    Emoji = "⛰️",
                    Badge = "Премиум"
                }
            };

            return View(featuredProducts);
        }

        // GET: Home/About - За нас
        public ActionResult About()
        {
            ViewBag.Title = "За нас";
            return View();
        }

        // GET: Home/Contact - Контакти
        public ActionResult Contact()
        {
            ViewBag.Title = "Контакти";
            return View();
        }

        // POST: Home/Contact - Изпращане на форма
        [HttpPost]
        public ActionResult Contact(string name, string email, string message)
        {
            // В реален проект тук бихме изпратили имейл
            ViewBag.Title = "Контакти";
            ViewBag.Message = "Благодарим! Съобщението е изпратено успешно.";
            return View();
        }
    }
}
