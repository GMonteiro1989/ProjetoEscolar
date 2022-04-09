using System;

namespace AjudaProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var reiniciar = true;
            string nomeAluno;
            string nomeProfessor = "";
            string salario = "";
            string ListaMateriais;
            string matriculaAluno;
            double nota1;
            double nota2;

            Console.WriteLine("Olá Seja bem vindo.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Digite 1 para cadastro de Professor ou 2 para calcular média dos alunos");

            int op = Convert.ToInt16(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        Professor p = new Professor(nomeProfessor, salario);
                        var status = p.CadastraProfessor();
                        Console.WriteLine(status);
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();

                        Console.WriteLine("O professor emitirá lista de materiais para compra? S/N");
                        ListaMateriais = Console.ReadLine();
                        if (ListaMateriais == "S")
                        {
                            var statusLista = p.ListadeMateriais();
                            Console.WriteLine(statusLista);
                        }
                        else
                        {
                            Console.WriteLine("Obrigado por utilizar nossos sistemas!");
                        }
                        break;
                    }
                case 2:
                    {
                        while (reiniciar)
                        {
                            Console.WriteLine("Informe o nome do aluno:");
                            nomeAluno = Console.ReadLine();
                            Console.WriteLine("Informe a matrícula do aluno:");
                            matriculaAluno = Console.ReadLine();
                            Console.WriteLine("Informe a primeira nota:");
                            nota1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Informe a segunda nota:");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (nota1 >= 0 && nota1 <= 10)
                            {
                                if (nota2 >= 0 && nota2 <= 10)
                                {
                                    Aluno a = new Aluno(nomeAluno, matriculaAluno, nota1, nota2);
                                    var resultado = a.CalculaMedia(a);
                                    var mensagem = a.ValidaMedia(resultado);

                                    Console.WriteLine(a.Nome + ", sua média final é " + resultado.ToString("F1") + ". " + mensagem);
                                    reiniciar = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Notas fora do intervalo permitido, Deseja informa-las novamente?S/N");
                                if (Console.ReadLine() == "S")
                                {
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    reiniciar = true;
                                }
                                else
                                {
                                    Console.WriteLine("Programa sendo encerrado.");
                                    System.Threading.Thread.Sleep(1000);
                                    reiniciar = false;
                                }

                            }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Opção Inválida. Programa sendo encerrado.");
                        break;
                    }
                 
            }
            
        }
    }
}
