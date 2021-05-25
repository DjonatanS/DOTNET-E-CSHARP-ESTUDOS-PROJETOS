using System.Globalization;

namespace Exercicio_Encapsulamento
{
    class Conta
    {
        public int Numero { get;private set; } // get disponivel para acesso dos dados
        // set privado para não alterar os dados 
        public string Titular { get; set; }
        public double Saldo { get;private set; }

      

        public Conta(int numero, string titular) { //Contrutor de 2 atributos
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial); //utilizar metodo de Deposito se ele é responsavel , por adicionar saldo na conta.
        }

        

        public override string ToString()
        {
            return $"Numero da Conta {Numero} Titular {Titular} saldo atual $ {Saldo.ToString("F2", CultureInfo.InvariantCulture) }";
        }
        public void Deposito(double saldo) {
             Saldo = Saldo + saldo;
        }

        public void Saque(double saldo) {

            Saldo = Saldo - 5 - saldo;

        }
    }

}
