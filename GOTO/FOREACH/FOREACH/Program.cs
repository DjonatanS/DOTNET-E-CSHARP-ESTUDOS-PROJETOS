using System;

namespace FOREACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "João", "Maria", "José" };
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
