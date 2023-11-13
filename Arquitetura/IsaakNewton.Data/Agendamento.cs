using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaakNewton.Data
{
    public enum Procedimentos
    {
        Radiografia = 0,
        Consulta = 1,
        Audiometria = 2,
        Tomografia = 3,
        RaioX = 4,
    }

    public class Agendamento : Base
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public Sala Sala { get; set; }
        public IEnumerable<Procedimentos> Procedimento { get; set; }
        public string DataAgendamento { get; set; }
    }
}