using System;
using System.IO;

namespace Diretorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Djona\OneDrive\Área de Trabalho\teste";
            try
            {

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
