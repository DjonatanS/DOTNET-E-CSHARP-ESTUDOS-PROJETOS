using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoque_OO
{
    class Produto
    {
        public string Nome;
        public int Quantidade;
        public double Valor;
     
        
      
        public double Total()
        {
            return Valor * Quantidade;
        }

        public void RemoverQuantidade(int remover)
        {
            Quantidade = Quantidade - remover;
        }
        public void AddQuantidade(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public override string ToString() //conversão da Classe para String
        {
            return "Você tem " + Quantidade + " " + Nome + " Valor total " + Total().ToString("F2") ;
        }
    }
}
