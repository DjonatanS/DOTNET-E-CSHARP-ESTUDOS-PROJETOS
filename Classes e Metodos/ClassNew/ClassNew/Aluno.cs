using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNew
{
    class Aluno
    {
       public string Nome { get; set; }
       public string Matricula { get; set; }

        public Aluno()
        {
        }
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }


        //metodo simples
        public void MostrarDados()
        {
            Console.WriteLine("Olá Meu nome é: " + Nome);
            Console.Write("Qual seu nome ? ");
            string username = Console.ReadLine();
            Console.WriteLine("Prazer em conhece-lo " + username);
          
        }


        //metodo com parametro
        public void Chamar(string nome)
        {
            Console.WriteLine("Oi você é o " + nome + " correto ?");
            Console.WriteLine("Eu me chamo " + Nome);
        }

        //metodo com retorno
        public string RetornarNome(string nome)
        {
            return nome;
        }
    }
}
