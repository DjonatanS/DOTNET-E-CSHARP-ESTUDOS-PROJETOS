using System;

namespace Sistema_Cad_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];

            var indiceAluno = 0;
            string resp = OpcaoUsuario();

            while (resp.ToUpper() != "X")
            {
                switch (resp)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do Aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota : ");

                        if (int.TryParse(Console.ReadLine(), out int nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser numerico");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (a.Nome != null)
                            {
                                Console.WriteLine($"Nome {a.Nome} Nota {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        var notaTotal = 0;
                        int numAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if(alunos[i].Nome != null)
                            {
                                notaTotal += alunos[i].Nota;
                                numAlunos++;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"A nota média dos alunos é de {notaTotal / numAlunos}");
                        
                        int média = notaTotal / numAlunos;
                        Conceito conceitoGeral;
                     if(média >= 8)
                        {
                            conceitoGeral = Conceito.A;
                            Console.WriteLine("Conceito : " + conceitoGeral);
                        }
                     else if(média >= 6)
                        {
                            conceitoGeral = Conceito.B;
                            Console.WriteLine("Conceito : " + conceitoGeral);
                        }
                     else if(média >= 4)
                        {
                            conceitoGeral = Conceito.C;
                            Console.WriteLine("Conceito : " + conceitoGeral);
                        }
                        else
                        {
                            conceitoGeral = Conceito.D;
                            Console.WriteLine("Conceito : " + conceitoGeral);
                        }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                resp = OpcaoUsuario();
            }

        }

        private static string OpcaoUsuario()
        {
            Console.WriteLine("Informe opção desejada");
            Console.WriteLine("1 - Inserir Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média");
            Console.WriteLine("x - Sair");

            string resp = Console.ReadLine();
            return resp;
        }
    }
}
