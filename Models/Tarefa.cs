using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoConsole.Models
{
    public class Tarefa
    {
        
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
        public DateTime Inicio { get; set; } = DateTime.Now;
        public DateTime Fim { get; set; } = DateTime.Now;

        
    }

}
