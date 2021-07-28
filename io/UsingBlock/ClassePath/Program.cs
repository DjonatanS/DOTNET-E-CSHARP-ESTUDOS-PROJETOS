using System;
using System.IO;

namespace ClassePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Djona\OneDrive\Área de Trabalho\teste\File.txt";

            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetDirectoryName(path));
           
        }
    }
}
