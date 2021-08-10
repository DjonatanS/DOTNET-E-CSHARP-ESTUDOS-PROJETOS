using System;
using LinqComLambda.Entities;
using System.Collections.Generic;
using System.Linq;
namespace LinqComLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Ferramentas", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computadores", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Eletronicos", Tier = 1 };


            List<Product> products = new List<Product>()
            {
                new Product() {ID = 1 , Name = "Computador" , Price = 1200 , Category = c2},
                new Product() {ID = 5 , Name = "Iphone" , Price = 1200 , Category = c2},
                new Product() {ID = 2 , Name = "Workstation" , Price = 2000 , Category = c2},
                new Product() {ID = 3 , Name = "Microondas" , Price = 200 , Category = c3},
                new Product() {ID = 4 , Name = "Serra" , Price = 50 , Category = c1}
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 2000);
            Print("Produtos Tier 1 Preço menor que 2000", r1);

            var r2 = products.Where(p => p.Category.Name == "Ferramentas").Select(p => p.Name);
            Print("Produtos de categoria Ferramentas", r2);

            var r3 = products.Where(p => p.Name[0] == 'W').Select(p => new { p.Name, p.Price });
            Print("Produtos que inicia com letra w", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Produtos Tier 1 , ordenados por Preço e senão por Nome", r4);

            var r5 = r4.Skip(1).Take(2);
            Print("Pula 1 resultado pega os 2 proximos", r5);

            var r6 = products.Where(p => p.ID == 3).SingleOrDefault();
            Console.WriteLine("ID 3" + r6);

            var r7 = products.Max(p => p.Price);
            Console.WriteLine("Produto de maior valor" + r7);

            Console.WriteLine();

            var r8 = products.Min(p => p.Price);
            Console.WriteLine("Produto de menor valor" + r8);

            Console.WriteLine();

            var r9 = products.Where(p => p.Category.Tier == 1).Sum(p => p.Price);
            Console.WriteLine("Soma valor categoria Tier 1 " + r9);


            // Pegar produtos categoria Tier 1 // selecioar apenas o preço caso não existe deixar vazio, senão
            //aplicar a média
            var r10 = products.Where(p => p.Category.Tier == 1).Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Média do valor categoria Tier 1 " + r10);

            //Criação personalizada 

            var r11 = products.Where(p => p.Category.Tier == 1).Select(p => p.Price).Aggregate((x, y) => x + y);


            Console.WriteLine("Soma tier 1 value com parametros personalizados " + r11);

            var r12 = products.GroupBy(p => p.Category);
            foreach(IGrouping<Category , Product> group in r12)
            {
                Console.WriteLine("Categora " + group.Key.Name + ":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
            }



        }
    }
}
