using System;

namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.WriteLine("Escolha");
            int op = int.Parse(Console.ReadLine());

            int valor = 0;

            switch (op)
            {
                default:
                    goto Inicio;
                    break;
                case 1:
                    valor += 10;
                    break;
                case 2:
                    valor += 20;
                    goto case 1;
                   

            }

            Console.WriteLine("Valor " + valor);

            Console.ReadKey();
        }
    }
}
