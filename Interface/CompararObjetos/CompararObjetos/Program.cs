using System;
using System.IO;
using System.Collections.Generic;
using CompararObjetos.Entities;

namespace CompararObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Djona\OneDrive\Área de Trabalho\teste\File.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
