using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsackNewton.Data
{
    public enum Procedimentos
    {
        Radiografia = 0,
        AudioMedritria = 1,
        Tomografia = 2,
        RaioX = 3, 
    }
    public class Agendamento: Base
    {
        public string DataAgendamento { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public Procedimentos Procedimento { get; set; }

        public override string ToString() {
            return base.ToString() + $"\nData: {DataAgendamento}\nMedico: {Medico.Nome}\nPaciente: {Paciente.Nome}\nProcedimento: {Procedimento}";
        }
    }
}
