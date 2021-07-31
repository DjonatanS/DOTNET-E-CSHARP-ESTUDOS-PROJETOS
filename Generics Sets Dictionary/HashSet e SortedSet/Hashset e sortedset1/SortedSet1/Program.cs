using System;
using System.Collections.Generic;

namespace SortedSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();
            set.Add("Djonatna");
            set.Add("Maria");
            set.Add("Alex");
            Console.WriteLine(set.Count);
            Console.WriteLine(set.Contains("Maria"));
            foreach(string i in set)
            {
                Console.WriteLine(i);
            }

            SortedSet<int> inteiros = new SortedSet<int>();
            SortedSet<int> inteiros2 = new SortedSet<int>() { 1, 5, 6, 12 };
            
            inteiros.Add(10);
            inteiros.Add(5);
            inteiros.Add(3);
            inteiros.Add(7);

            PrintCollection(inteiros);

            //union
            SortedSet<int> unir = new SortedSet<int>(inteiros);
            unir.UnionWith(inteiros2);
            PrintCollection(unir);


            //intersection
            SortedSet<int> interseccao = new SortedSet<int>(inteiros);
            interseccao.IntersectWith(inteiros2);
            PrintCollection(interseccao);

            //diference 
            SortedSet<int> diference = new SortedSet<int>(inteiros);
            diference.ExceptWith(inteiros2);
            PrintCollection(diference);






        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
