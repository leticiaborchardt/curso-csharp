using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;

namespace IsacNewton.Service.PacienteService.Implements
{
    public class CrudPaciente
    {
        private static List<Paciente> pacientes = new List<Paciente>();
        private static int ProximoId;

        public void Create(Paciente model)
        {
            model.Id = ProximoId++;
            pacientes.Add(model);
        }

        public void Delete(int id)
        {
            Paciente paciente = new Paciente();

            foreach (Paciente i in pacientes) {
                if (i.Id == id) {
                    paciente = i;
                }
            }

            pacientes.Remove(paciente);
        }

        public List<Paciente> Read()
        {
            Console.WriteLine("---------Lista de Pacientes---------");
            return pacientes;
        }

        public void Update(Paciente model)
        {
            Paciente? pacienteExistente = pacientes.Find(x => x.Id == model.Id);

            if (pacienteExistente != null)
            {
                pacienteExistente.Nome = model.Nome;
                pacienteExistente.SobreNome = model.SobreNome;
                pacienteExistente.DataNacimento = model.DataNacimento;
                pacienteExistente.Documento = model.Documento;
                pacienteExistente.Contato = model.Contato;
                pacienteExistente.Responsavel = model.Responsavel;
                pacienteExistente.genero = model.genero;
                pacienteExistente.Convenio = model.Convenio;
                pacienteExistente.RestricaoMedica = model.RestricaoMedica;

                Console.WriteLine("Paciente atualizado!");
            }
            else
            {
                throw new ArgumentException("Paciente não encontrado.");
            }

        }
    }
}
