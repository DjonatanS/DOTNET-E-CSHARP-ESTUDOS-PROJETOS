using System;

namespace DelegateReview
{
    internal class Program
    {

        public delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            Mathe m = new Mathe();
            

            Operacao conta = null;

            conta += m.Soma;
            conta += m.Subtracao;
            conta += m.Multiplicacao;
            conta += m.Divisao;

            conta(10, 5);
            
        }
    }
}
