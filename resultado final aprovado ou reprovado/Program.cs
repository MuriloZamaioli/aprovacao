using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace resultado_final_aprovado_ou_reprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            int faltas = 0;
            bool flag = false;

            try
            {

                while (!flag)
                {
                    Console.Write("Digite a média (ou 'S' para sair): ");
                    string inputMedia = Console.ReadLine();

                    if (inputMedia.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }
                    try
                    {
                        media = double.Parse(inputMedia);

                        if (media < 0 || media > 10)
                        {
                            Console.WriteLine("ERRO: Digite um número entre 0 e 10");
                            continue;
                        }
                        if (media < 7)
                        {
                            Console.WriteLine("Você está reprovado");
                            return;
                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Digite um número válido!");
                    }
                }

                flag = false;

                while (!flag)
                {
                    Console.Write("Digite o número de faltas (ou 'S' para sair): ");
                    string inputFaltas = Console.ReadLine();

                    if (inputFaltas.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }
                    try
                    {
                        faltas = int.Parse(inputFaltas);

                        if (faltas < 0)
                        {
                            Console.WriteLine("Digite um número positivo");
                            continue;
                        }
                        if (faltas > 100)
                        {
                            Console.WriteLine("Digite um número mais baixo");
                            continue;
                        }
                        if (faltas > 20)
                        {
                            Console.WriteLine("Você está reprovado");
                            return ;
                        }
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Digite um número válido!");
                    }
                }
                Console.WriteLine("Você está aprovado!");
            }
            finally
            {
                Console.WriteLine("Operação concluída");
                Console.ReadKey();
            }


            











            
        }
    }
}
