using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        { 
            if (!content.Category.Any()) { 
                content.Category.AddRange(Categories.Select(c => c.Value)); }
               
            if (!content.Car.Any())
                content.AddRange(new Car
                {
                    name = "Tesla",
                    shortDesc = "super car",
                    longDesc = "very super car",
                    img = "/img/tesla 1.png",
                    price = 45000,
                    isFavorite = true,
                    available = true,
                    Category = Categories["Electro"]
                },
                    new Car
                    {
                        name = "Tesla 2",
                        shortDesc = "super car",
                        longDesc = "very super and expencive super car",
                        img = "/img/Tesla 2.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Electro"]
                    },
                    new Car
                    {
                        name = "Volvo",
                        shortDesc = "",
                        longDesc = "",
                        img = "/img/wolvo.jpg",
                        price = 35000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Disel"]
                    },
                    new Car
                    {
                        name = "Opel",
                        shortDesc = "german car",
                        longDesc = "very old concern",
                        img = "/img/opel.jpg",
                        price = 10000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Disel"]
                    }) ;
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                        new Category { categoryName = "Electro", desc = "newOne cars" },
                        new Category { categoryName = "Disel", desc = "used German cars" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);


                }
                return category;
            }
        }
    }
}
