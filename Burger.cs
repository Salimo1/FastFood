using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class Burger
    {
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Burger(string ingredients, double price)
        {
            Ingredients = ingredients;
            Price = price;
        }
    }
}
