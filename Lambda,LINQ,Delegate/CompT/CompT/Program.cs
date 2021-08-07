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


            //Metodo de comparação utilizando expressão lambda
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            Comparison<Product> preco = (p1, p2) => p1.Price.CompareTo(p2.Price);
            Console.Write("Ordernar produtos por preco digite 1, por nome digite 2");
            int resp = int.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    list.Sort(preco);//expressão lambda pode ser inserida diretamente como parametro no arg do sort
                    foreach (Product produto in list)
                    {
                        Console.WriteLine(produto);
                    } break;
                case 2:
                    list.Sort(comp);
                    foreach (Product produto in list)
                    {
                        Console.WriteLine(produto);
                    }
                    break;

            }
            
        

        }
        /*metodo de comparação
        static int CompareProduct(Product p1 , Product p2)
        {
            return p1.Name.ToLower().CompareTo(p2.Name);
        } */
    }
}
