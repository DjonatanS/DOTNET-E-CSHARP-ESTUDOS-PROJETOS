using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Caixa : IConta
    {
        public string Titular { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Depositar(double valor)
        {
            throw new NotImplementedException();
        }

        public void MostrarSaldo()
        {
            throw new NotImplementedException();
        }

        public void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }


    interface IConta
    {
        string Titular { get; set; }
        void Sacar(double valor);
        void Depositar(double valor);
        
        void MostrarSaldo();
    }   
}
