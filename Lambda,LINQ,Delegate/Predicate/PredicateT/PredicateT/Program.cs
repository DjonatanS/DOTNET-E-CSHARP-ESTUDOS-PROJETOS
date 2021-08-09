using System;
using System.Collections.Generic;

namespace PredicateT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            list.RemoveAll(ReturnProduct);

            foreach(Product a in list)
            {
                Console.WriteLine(a);
            }
        }

        public static bool ReturnProduct(Product p)
        {
            return p.Price <= 100;
        }
    }
}
