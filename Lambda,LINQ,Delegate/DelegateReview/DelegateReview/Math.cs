using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateReview
{
    public class Mathe
    {
        public void Soma(int x, int y)
        {
            Console.WriteLine("Soma: " + (x + y));
        }

        public void Subtracao(int x, int y)
        {
            Console.WriteLine("Subtracao: " + (x - y));
        }

        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine("Multiplicacao: " + (x * y));
        }

        public void Divisao(int x, int y)
        {
            Console.WriteLine("Divisao: " + (x / y));
        }

    }
}
