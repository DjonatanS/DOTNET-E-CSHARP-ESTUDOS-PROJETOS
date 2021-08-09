using System;
using System.Linq;

namespace LinqIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {

            //Introdução ao Linq
            //Especificar Fonte de dados

            int[] numbers = new int[] { 2, 3, 5, 6, 7 };

            //Definir Consulta

            var result = numbers
                .Where(x => x % 2 == 0) //Seleciona pares dentro do array numbers
                .Select(x => x * 10);   //Multiplica por 10


            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
