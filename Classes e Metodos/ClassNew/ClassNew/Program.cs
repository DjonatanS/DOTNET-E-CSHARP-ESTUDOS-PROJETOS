using System;

namespace ClassNew
{
    public class Program
    {
        static void Main(string[] args)
        {

            string nome = "Djonatan";
            string nome2 = "Lucas";
            Aluno aluno = new Aluno("João", "123456789");
            Aluno aluna = new Aluno();

            Aluno semnome = new Aluno();
            
            //Utilizando return do metodo
            string nomes =  semnome.RetornarNome(nome2);
            Console.WriteLine(nomes);

            Aluno alunos = new Aluno()
            {
                Nome = "Jones",
                Matricula = "987654321"
            };

            SOMA soma = new SOMA();

            aluna.Nome = "Maria";
            aluna.Matricula = "987654321";

            Console.WriteLine(alunos.Nome);
            Console.WriteLine("Digite valor");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine(valor);
            soma.Aumentar(valor);

            Console.WriteLine("Antes da ref : " + valor);
            soma.AumentarRef(ref valor); //manipula na valor original
            Console.WriteLine("Depois do ref: " +valor);


            Console.WriteLine(aluna.Nome);
            Console.WriteLine(aluno.Nome);


            aluna.MostrarDados();


            aluna.Chamar(nome);


            Console.WriteLine("Selecione um numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecione um numero");
            int numero2 = int.Parse(Console.ReadLine());

           
            
            soma.soma(numero, numero2);
        }
        
    }

}
