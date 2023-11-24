using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsackNewton.Data
{
    public class Paciente: Pessoa
    {
        public string Convenio { get; set; }
        public string RestricaoMedica { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nNº de Convênio: {Convenio}\nRestrição Médica: {RestricaoMedica}";
        }
    }
}
