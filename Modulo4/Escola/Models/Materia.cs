using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo4.Escola.Models
{
    public class Materia: BaseModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}\nNome: {this.Nome}\nDescrição: {this.Descricao}";
        }
    }
}