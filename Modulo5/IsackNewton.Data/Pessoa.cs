using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsackNewton.Data
{
    public class Pessoa: Base
    {
        public string Nome { get; set; }
        public string SobreNome { get; set;}  
        public string DataNacimento { get; set; }
        public string Documento { get; set;}  
        public string Contato { get; set;}
        public string Responsavel { get; set; }
        public string genero { get; set;}

        public override string ToString()
        {
            return base.ToString() + $"\nNome: {Nome} {SobreNome}\nData de Nascimento: {DataNacimento}\nDocumento: {Documento}\nContato: {Contato}\nResponsável: {Responsavel}\nGênero: {genero}";
        }
    }
}
