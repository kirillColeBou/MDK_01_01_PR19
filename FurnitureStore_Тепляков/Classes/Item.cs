using System;
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
        public string filter { get; set; }
        public int count { get; set; }

        public Item(string _name, int _price, string _img, string _filter, int _count)
        {
            this.name = _name;
            this.price = _price;
            this.img = _img;
            this.filter = _filter;
            this.count = _count;
        }
    }
}
