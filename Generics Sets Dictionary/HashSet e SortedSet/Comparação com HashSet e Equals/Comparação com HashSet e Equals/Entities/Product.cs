using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comparação_com_HashSet_e_Equals.Entities
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

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
           if(!(obj is Product)) {
                return false;
           }
            Product other = obj as Product; //Downcasting
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
