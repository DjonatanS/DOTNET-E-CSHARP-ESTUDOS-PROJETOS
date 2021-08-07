using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CompT.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        

        public override string ToString()
        {
            return $"Nome: {Name} Preço: {Price}";
        }

     
    }
}
