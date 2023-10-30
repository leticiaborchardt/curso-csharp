using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo4.Escola.Models
{
    public class Pessoa : BaseModel
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        public override string ToString()
        {
            return $"ID: {this.Id}\nNome: {this.Nome}\nSobrenome: {this.Sobrenome}\nCódigo da matrícula: {this.Matricula}";
        }
    }
}