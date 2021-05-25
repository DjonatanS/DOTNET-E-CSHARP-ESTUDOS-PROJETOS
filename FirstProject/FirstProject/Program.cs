using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Saida de Dados
            /*
            int idade = 32;
            char genero = 'F';
            double saldo = 3209.3923;
            string nome = "Maria";
            
            Console.WriteLine("Bom Dia!");
            Console.WriteLine("Boa Tarde!");

            Console.WriteLine("Minha idade " + idade); // Concatenar variavel com a String
            
            Console.WriteLine("Genero " + genero);
            

            Console.WriteLine("Seu Saldo " + saldo.ToString("F2")); //Metodo para fixar quantia de casas decimais
          
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //Metodo de Concatenação utilizando Placeholder.

            Console.WriteLine($"{nome} tem {idade} e seu saldo é de {saldo:F2}");
            //Metodo de interpolação.
        */
            #endregion

            #region Exercicio Fixação 1
            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");

            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade código:{codigo} genero: {genero} ");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais " + medida.ToString("F8"));
            Console.WriteLine($"Arredondando para 3 casas decimais: {medida:F3}");
            Console.WriteLine("trocar virgula por ponto " + medida.ToString("F2", CultureInfo.InvariantCulture));
            */
            #endregion

            #region Conversão Explicita
            /*
             double a = 500;
             float b = (float)a;
             //Metodo de Conversão Explicita(Casting);

             int num1 = 5;
             int num2 = 2;
             double resultado = (double)num1 / num2;
             Console.WriteLine(resultado);
            */
            #endregion

            #region entrada de dados 1
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine("Você Digitou...");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */
            /*

            string[] vet = Console.ReadLine().Split(' '); //Criação de Vetor VET atribuindo palavras separadas por espaço
            string p1 = vet[0]; // indice 0 do vetor , recebe 1 palavra.
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"{p1} {p2} {p3}");
            */
            #endregion

            #region teste1 
            /*
            Console.WriteLine("Digite Seu nome Completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa ?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua idade ?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome} sua idade é {idade} e tem {quartos} quartos na sua casa");

            */
            #endregion

            #region Entrada de dados 2
            /*
            string nome = Console.ReadLine();
            int idade = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Confirme seus dados, seu nome é {nome} ");
            Console.WriteLine($"Você tem {idade} anos de idade e seu saldo atual é de {valor:F2} reais");
            */
            /*
            string[] vetor = Console.ReadLine().Split(' ');

            string nomes = vetor[0];
            int idade = int.Parse(vetor[2]);
            double saldo = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.Write(nomes);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture));

            */
            #endregion


            #region Estrutura Condicional

            /*
            Console.Write("Digite um numero ");
            int x = int.Parse(Console.ReadLine());

            if( x % 2 == 0)
            {
                Console.WriteLine($"o numero que você digitou foi {x} ele é par");
            }
            else Console.WriteLine($"o numero que você digitou foi {x} ele é impar");
            */




            #endregion

            #region Função Sintaxe
            /*
            Console.WriteLine("Digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); // Chamada de Função Maior

            Console.WriteLine("Maior numero é " + resultado);
            */
            #endregion


            #region Estrutura de Repetição While
            /*
                        Console.WriteLine("Digite um numero ");
                        double raiz = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        while(raiz >= 0)
                        {
                            Console.WriteLine("A Raiz do " + raiz + "é" + Math.Sqrt(raiz),CultureInfo.InvariantCulture);
                            Console.WriteLine("Digite outro Numero ");
                            raiz = double.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Numero negativo");
            

            Console.Write("Digite sua senha ");
            string senha = Console.ReadLine();
            while(senha != "djtattoo123")
            {
                Console.WriteLine("Senha Invalida, tente novamente");
                Console.Write("Digite sua senha ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");
            */
            #endregion

            #region Estrutura de Repetição FOR

            Console.Write("Quantos valores deseja somar ? ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int soma = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine($"Digite o #{i} valor!");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine($"o valor total da soma é {soma}");


            #endregion
        }

        #region Função Maior 
        // Criando função
        /*
        static int Maior (int a , int b , int c)
        {
            int maior;
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else maior = c;

            return maior;
        
    }*/ //final function Maior 
        #endregion
    }
}
