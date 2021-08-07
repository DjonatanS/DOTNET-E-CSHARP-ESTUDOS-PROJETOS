using System;
using System.Collections.Generic;
using System.Globalization;
using CompT.Entities;

namespace CompT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 840));
            list.Add(new Product("IPhone", 2500));
            list.Add(new Product("Notebook", 3201));

            list.Sort();
            foreach(Product produto in list)
            {
                Console.WriteLine(produto);
            }

        }
    }
}
