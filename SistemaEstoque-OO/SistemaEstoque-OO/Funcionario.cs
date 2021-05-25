using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoque_OO
{
    class Funcionario
    {
        double aux = ;
        public string Nome;
        public double SalarioB;
        public double Imposto;


        public double SubirSalario(double aumento)
        {
            aumento = aumento + aux;
           
            SalarioB = SalarioB * aumento  ;
        }
    }
}
