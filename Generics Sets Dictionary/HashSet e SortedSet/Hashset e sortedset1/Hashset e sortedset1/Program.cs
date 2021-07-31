using System;
using System.Collections.Generic;

namespace Hashset_e_sortedset1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Djonatan");
            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Djonatan"));
            Console.WriteLine(set.Count);

            foreach(string i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
