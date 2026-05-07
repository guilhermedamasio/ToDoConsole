using System;



namespace ToDoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a) ao aplicativo ToDo do Guilherme Damasio!");
            List<string> listaTarefa = new List<string>();
            string opcao = "";
            

            while (opcao != "e")
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar uma tarefa.");
                Console.WriteLine("2 - Ver todas as tarefas adicionadas.");
                Console.WriteLine("3 - Remover uma tarefa.");
                Console.WriteLine("4 - Sair do programa.");
                opcao = Console.ReadLine();
                
                if (opcao == "1")
                {
                    Console.WriteLine("Por favor, insira o nome da tarefa para adicionar ao aplicativo.");
                    string nomeTarefa = Console.ReadLine();
                    listaTarefa.Add(nomeTarefa);
                    Console.WriteLine("Tarefa adicionada com sucesso!");

                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Tarefas adicionadas:");
                    for (int i = 0; i < listaTarefa.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {listaTarefa[i]}");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Digite o número da tarefa que deseja remover:");
                    int numeroTarefa;
                    if (int.TryParse(Console.ReadLine(), out numeroTarefa) && numeroTarefa > 0 && numeroTarefa <= listaTarefa.Count)
                    {
                        string tarefaRemovida = listaTarefa[numeroTarefa - 1];
                        listaTarefa.RemoveAt(numeroTarefa - 1);
                        Console.WriteLine($"Tarefa '{tarefaRemovida}' removida com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarefa inválido. Por favor, tente novamente.");
                    }
                }
                else if (opcao == "4") 
                {
                    Console.WriteLine("\nSaindo do programa. Até mais!");
                    opcao = "e";
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
                
            }
        }
    }
}