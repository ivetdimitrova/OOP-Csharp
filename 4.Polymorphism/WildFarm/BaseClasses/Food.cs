﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public  class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
