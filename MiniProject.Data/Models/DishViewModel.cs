﻿using System.Collections.Generic;
using MiniProject.data.Models;

namespace MiniProject.Data.Models
{
    public class DishViewModel
    {
        public Restaurant Restaurant { get; set; }
        public Dish Dish { get; set; }
        
        public  List<Dish> Cart { get; set; }
    }
}