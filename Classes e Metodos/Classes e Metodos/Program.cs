using System;
using System.Globalization;

namespace Classes_e_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Problema sem Orientação a objetos
            /*
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do Triangulo X ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do Triangulo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area triangulo X " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area triangulo Y " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            */
            #endregion



            #region Utilizando Orientação a Objetos
            /*
            Triangulo x, y; // Chamando a Class triangulo

            x = new Triangulo(); //instanciando o triangulo X
            y = new Triangulo(); // instanciando o triangulo Y

            Console.WriteLine("Entre com as medidas do Triangulo X ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcArea();


            double areaY = y.CalcArea();

            Console.WriteLine("Area triangulo X " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area triangulo Y " + areaY.ToString("F4", CultureInfo.InvariantCulture));
           */
            #endregion



            #region Exercicio OO
            /*
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.Write("Digite o nome da Primeira pessoa ");
            x.Nome = Console.ReadLine();

            Console.Write("Digite a Idade da Primeira pessoa ");
            x.Idade = int.Parse(Console.ReadLine());

            //pessoa 2
            Console.Write("Digite o nome da Segunda pessoa ");
            y.Nome = Console.ReadLine();

            Console.Write("Digite a Idade da Segunda pessoa ");
            y.Idade = int.Parse(Console.ReadLine());


            if(x.Idade > y.Idade)
            {
                Console.WriteLine($"{x.Nome} é a pessoa mais velha , tem {x.Idade} anos");
            }
            else Console.WriteLine($"{y.Nome} é a pessoa mais velha , tem {y.Idade} anos ");
            */
            #endregion


            #region Exercicio OO 2
            /*
              Funcionarios a, b;

              a = new Funcionarios();

              b = new Funcionarios();

              Console.WriteLine("Digite o nome do Primeiro Funcionario ");
              a.Nome = Console.ReadLine();

              Console.WriteLine("Digite o cargo do Primeiro Funcionario ");
              a.Cargo = Console.ReadLine();

              Console.WriteLine("Digite o salario do Primeiro Funcionario ");
              a.Salario = double.Parse(Console.ReadLine());




              //Funcionario 2
              Console.WriteLine("Digite o nome do Segundo Funcionario ");
              b.Nome = Console.ReadLine();

              Console.WriteLine("Digite o cargo do Segundo Funcionario ");
              b.Cargo = Console.ReadLine();

              Console.WriteLine("Digite o salario do Segundo Funcionario ");
              b.Salario = double.Parse(Console.ReadLine());

              double media = (a.Salario + b.Salario) / 2;

              Console.WriteLine("A média salarial é " + media + " reais");
            */

            #endregion

            #region
            Funcionarios a;
            a = new Funcionarios();
            Console.WriteLine("Nome");
            a.Nome = Console.ReadLine();
                Console.WriteLine("salario"  );
            a.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto");
            a.Imposto = double.Parse(Console.ReadLine());
            a.SalarioLiquido();

            Console.WriteLine("Aumento");
            double aum = double.Parse(Console.ReadLine());
            a.AumentarSalario(aum);

            Console.WriteLine(a);

            #endregion

        }


    }
}
