using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenca
{
    abstract class Veiculo //Classe abstrata não pode ser instanciada diretamente serve apenas como base para outras classes
    {
        public string Cor
        {
            get; set;
        }
        public string Marca
        {
            get; set;
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }
        public void Frear()
        {
            Console.WriteLine("freando");
        }
    }
}
