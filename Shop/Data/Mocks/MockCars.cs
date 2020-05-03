using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "super car",
                        longDesc = "very super car",
                        img = "/img/tesla 1.png",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
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
                        Category = _categoryCars.AllCategories.First()
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
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set  ; }

        public Car getOjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
