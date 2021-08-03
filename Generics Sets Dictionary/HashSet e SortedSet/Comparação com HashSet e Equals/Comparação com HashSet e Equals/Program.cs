using System;
using Comparação_com_HashSet_e_Equals.Entities;
using System.Collections.Generic;
namespace Comparação_com_HashSet_e_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 700));
            a.Add(new Product("Iphone", 2700));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(10, 10));
            b.Add(new Point(5, 10));

            Product prod = new Product("TV", 700);
            Console.WriteLine(a.Contains(prod));


        }
    }
}
