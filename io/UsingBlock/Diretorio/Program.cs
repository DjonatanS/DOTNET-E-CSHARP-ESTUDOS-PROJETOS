using System;
using System.IO;
using System.Collections.Generic;

namespace Diretorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Djona\OneDrive\Área de Trabalho\teste";
            try
            {
                //listar pastas
              IEnumerable<string> folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
               
                Console.WriteLine("Folders:");
                foreach(string s in folder)
                {
                    Console.WriteLine(s);
                }
                //Listar arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }


                //Criar pasta


                Directory.CreateDirectory(path + "\\PASTA");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
