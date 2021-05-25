using System;
using System.Globalization;
namespace Membros_Estaticos
{
    class Program
    {
       
        

        static void Main(string[] args)
        {
            /*
            Console.Write("Digite o valor do raio ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferencia " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            */


            Console.WriteLine("Valor dolar ");
            double dolar = double.Parse(Console.ReadLine());
           
            Console.WriteLine(Conversor.Dolar(dolar));
            Console.WriteLine("Valor em Reais ? ");
            double reais = double.Parse(Console.ReadLine());
            Console.WriteLine("o Valor total em dolar é de " + Conversor.Valor(reais,dolar));
        }
   
      
    
    }
}
