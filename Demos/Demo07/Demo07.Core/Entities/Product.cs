﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo07.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string   Name { get; set; }
        public string Brand { get; set; }

        public decimal Price { get; set; }
    }
}
