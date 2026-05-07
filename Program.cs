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

                }



                
            }
        }
    }
}