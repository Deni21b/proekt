using System;
using System.Collections.Generic;

namespace HoneyShop.Models
{
    // Клас - модел за продукт
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }         // Наименование
        public string Description { get; set; }  // Описание
        public decimal Price { get; set; }        // Цена
        public string Weight { get; set; }        // Тегло (500г, 1кг...)
        public string ImageClass { get; set; }    // CSS клас за картинка
        public string Emoji { get; set; }         // Емоджи икона
        public string Badge { get; set; }         // Бадж (Ново, Хит...)
        public bool IsAvailable { get; set; }     // Наличност
    }
}
