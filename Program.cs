using System;



namespace ToDoConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo(a) ao aplicativo ToDo do Guilherme Damasio!");
            UI.Menu.ExibirMenu();
        }

        class Tarefa
        {
            public string Descricao { get; set; }
            public bool Concluida { get; set; }
            public Tarefa(string descricao)
            {
                Descricao = descricao;
                Concluida = false;
            }
        }
    }
}