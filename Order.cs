﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood
{
    class Order
    {
        public double Price { get; set; }
        private List<Meal> meal;

        public Order()
        {
           meal = new List<Meal>();
        }
    }


}
