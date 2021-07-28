using System;
using System.IO;

namespace FileStreamS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Djona\OneDrive\Área de Trabalho\File.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs =new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
               
            }
            catch(IOException e)
            {
                Console.WriteLine("An error Ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
