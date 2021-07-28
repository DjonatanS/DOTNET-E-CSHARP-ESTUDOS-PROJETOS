using System;
using System.IO;

namespace FileIo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Djona\OneDrive\Área de Trabalho\File.txt";
            string targetPath = @"C:\Users\Djona\OneDrive\Área de Trabalho\File2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) { Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
