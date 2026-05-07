using System;
using System.Collections.Generic;
using System.Text;
using ToDoConsole.Models;

namespace ToDoConsole.Services
{
    public class TarefaService
    {
        public List<Tarefa> listaDeTarefas = new List<Tarefa>();
        public void AdicionarTarefa(Tarefa tarefa)
        {
            listaDeTarefas.Add(tarefa);
        }
        public void ListarTarefas()
        {
            foreach (var tarefa in listaDeTarefas)
            {
                Console.WriteLine($"Tarefa: {tarefa.Descricao}");
            }
        }
        public void RemoverTarefa(Tarefa tarefa)
        {
            listaDeTarefas.Remove(tarefa);
        }
    }
}