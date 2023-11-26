﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore_Тепляков.Classes
{
    public class Item
    {
        public string name {  get; set; }
        public int price { get; set; }
        public string img { get; set; }

        public Item(string _name, int _price, string _img)
        {
            this.name = _name;
            this.price = _price;
            this.img = _img;
        }
    }
}
