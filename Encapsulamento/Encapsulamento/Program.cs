using System;
using System.Globalization;
using System.Collections;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500 , 10);
            p.Nome = "tv";
            Console.WriteLine(p);
            Console.WriteLine(p.Preco);
        }
    }
}
