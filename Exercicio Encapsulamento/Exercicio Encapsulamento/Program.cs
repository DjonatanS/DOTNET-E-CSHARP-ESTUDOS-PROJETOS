using System;
using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {


            Conta conta;


            Console.Write("Entre com o numero da Conta bancaria ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do Titular da Conta ");
            string titular = Console.ReadLine();
            Console.Write("A conta possui um saldo inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.Write("Entre com o valor do deposito ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new Conta(numero, titular, depositoInicial); // atribuindo dados a nova conta com 3 param , apenas se tiver deposito inicial
            }
            else
            {
                conta = new Conta(numero, titular); //sem deposito inicial apenas 2 param
            }


            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);

            Console.Write("Entre com o valor de deposito ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(conta);
            Console.Write("Entre com o valor de saque ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);




        }
    }
}
