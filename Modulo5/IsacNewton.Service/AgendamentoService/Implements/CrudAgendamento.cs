using IsackNewton.Data;
using IsacNewton.Service.AgendamentoService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsacNewton.Service.AgendamentoService.Implements
{
    public class CrudAgendamento : IAgendamento
    {
        private static List<Agendamento> agendamentos = new List<Agendamento>();
        private static int Id;

        public void Create(Agendamento model)
        {
            model.Id = ++Id;
            agendamentos.Add(model);
            Console.WriteLine("---------Agendamento salvo com sucesso!!!--------");
        }

        public void Delete(int id)
        {
            Agendamento agendamentoEscolhido = agendamentos.Find(x => x.Id == id);
            agendamentos.Remove(agendamentoEscolhido);
            Console.WriteLine("---------Agendamento Deletado com sucesso!!!--------");
        }

        public List<Agendamento> Read()
        {
            return agendamentos;
        }

        public void Update(Agendamento model)
        {
            Agendamento agendamentoEscolhido = agendamentos.Find(x => x.Id == model.Id);

            agendamentoEscolhido.DataAgendamento = model.DataAgendamento;
            agendamentoEscolhido.Paciente = model.Paciente;
            agendamentoEscolhido.Medico = model.Medico;
            agendamentoEscolhido.Procedimento = model.Procedimento;
            Console.WriteLine("---------Agendamento Atualizado com sucesso!!!--------");
        }
    }
}
