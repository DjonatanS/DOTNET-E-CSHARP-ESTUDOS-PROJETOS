using System;
using System.IO;

namespace StreamWriterr
{
    class Program
    {
        static void Main(string[] args)
        {
            string spath = @"C:\Users\Djona\OneDrive\Área de Trabalho\File.txt";
            string tpath = @"C:\Users\Djona\OneDrive\Área de Trabalho\File1.txt";

            try
            {
                string[] lines = File.ReadAllLines(spath);
                using (StreamWriter sw = File.AppendText(tpath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
