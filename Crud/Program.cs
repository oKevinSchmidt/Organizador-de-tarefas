using System;
using System.ComponentModel;
using System.Globalization;

namespace Crud
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            
            int op = 0;

            List<Afazeres> ListaTarefas = new List<Afazeres>();

            while (op != 5)
            {
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("|   ORGANIZADOR DE TAREFAS   |");
                Console.WriteLine("+--+----------------------+--+");
                Console.WriteLine("   |1 - Adicionar tarefa  |");
                Console.WriteLine("   |2 -  Listar tarefas   |");
                Console.WriteLine("   |3 -  Remover tarefa   |");
                Console.WriteLine("   |4 -   Limpar lista    |");
                Console.WriteLine("   |5 -       Sair        |");
                Console.WriteLine("   +----------------------+");

                Console.Write("->");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (op == 1)
                {
                    Console.Write("Adicionar tarefa -> ");
                    ListaTarefas.Add(new Afazeres(Console.ReadLine()));
                    Console.WriteLine();
                }
                else if (op == 2)
                {
                    Console.WriteLine("+----------------------+");
                    Console.WriteLine("|   LISTA DE TAREFAS   |");
                    Console.WriteLine("+----------------------+");

                    foreach (Afazeres k in ListaTarefas)
                    {
                        Console.Write(" - ");
                        Console.WriteLine(k);
                    }
                    Console.WriteLine();

                }
                else if (op == 3)
                {
                    Console.WriteLine("Qual tarefa deseja remover?");
                    string remover = Console.ReadLine();

                    Afazeres tarefaRemover = ListaTarefas.Find(t => t.Tarefa == remover);

                    if (tarefaRemover != null)
                    {
                        ListaTarefas.Remove(tarefaRemover);
                        Console.WriteLine("Tarefa removida com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Tarefa não encontrada.");
                    }
                    Console.WriteLine();
                }

                else if (op == 4)
                {
                    ListaTarefas.Clear();
                    Console.WriteLine("Todas as tarefas foram removidas!");
                }
                else if(op == 5)
                {
                    Console.WriteLine("Encerrando Organizador de tarefas...");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
                Console.WriteLine();
                
            }



        }
    }
}