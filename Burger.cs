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
        public int Price { get; set; }

        public Burger(string ingredients, int price)
        {
            Ingredients = ingredients;
            Price = price;
        }
    }
}
