using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank); //linhas
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
                
                
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i,i]);
            }
            */

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1: day = "Segunda";
                    break;
                case 2: day = "Terça";
                    break;
            }

            int a = 2;
            int b = 1;
            
        }
    }
}
