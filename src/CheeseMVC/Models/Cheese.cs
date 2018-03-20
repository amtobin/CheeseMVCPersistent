﻿using System.Collections.Generic;
using CheeseMVC.Models;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int ID { get; set; }

        public int CategoryID { get; set; } //represents the foreign key
        public CheeseCategory Category { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; }
    }
}
