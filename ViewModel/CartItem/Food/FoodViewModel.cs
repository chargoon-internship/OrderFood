﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.CartItem.Food
{
    public class FoodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Exist { get; set; }
        public string ExistText
        {
            get { return Exist ? "موجود" : "ناموجود"; }
        }
    }
}