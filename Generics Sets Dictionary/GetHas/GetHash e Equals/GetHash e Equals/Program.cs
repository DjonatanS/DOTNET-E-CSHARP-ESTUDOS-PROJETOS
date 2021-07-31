using System;
using GetHash_e_Equals.Entities;
namespace GetHash_e_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client c = new Client();
            string name = "Djonatan";
            c.Name = name;
            c.Email = "Djo";

            Client d = new Client();
            d.Email = "Djo";

            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
        }
    }
}
