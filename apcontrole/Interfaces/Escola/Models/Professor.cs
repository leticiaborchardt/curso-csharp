using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.Interfaces.Escola.Models
{
    public class Professor : Pessoa
    {
        // Composição
        public List<Materia> Materias { get; set; }

        public override string ToString()
        {
            string materias = "";
            
            foreach (var materia in this.Materias)
            {
                materias += $"\n{materia.Nome}";
            }
                
            return base.ToString() + $"\nMatérias: {materias}";
        }
    }
}