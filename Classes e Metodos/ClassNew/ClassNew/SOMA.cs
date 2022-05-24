using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNew
{
    public class SOMA
    {
        int n1 { get; set; }
        int n2 { get; set; }
        

        
        public void soma(int n1 , int n2)
        {

            Console.WriteLine("Soma: " + (n1 + n2));
        }


        //param por valor
        public void Aumentar(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor: " + valor);
        }



        //param por ref
        public void AumentarRef(ref int valor) //manipula valor original
        {
            valor += 10;
            Console.WriteLine("Valor: " + valor);
        }
    }
}
