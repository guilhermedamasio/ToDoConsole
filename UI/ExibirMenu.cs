using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoConsole.UI
{
    public static class Menu
    {
        public static void ExibirMenu()
        {

            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar uma tarefa.");
            Console.WriteLine("2 - Ver todas as tarefas adicionadas.");
            Console.WriteLine("3 - Remover uma tarefa.");
            Console.WriteLine("4 - Sair do programa.");
        }
    }
}
