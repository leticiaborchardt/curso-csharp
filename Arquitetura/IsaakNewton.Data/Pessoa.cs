using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaakNewton.Data
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Genero { get; set; }
        public string DataNascimento { get; set; }
        public string Documento { get; set;}
        public string Contato { get; set; }
        public Pessoa Responsavel { get; set; }
    }
}