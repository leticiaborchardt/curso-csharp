using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.MedicoService.Interface;

namespace IsacNewton.Service.MedicoService.Implements
{
    public class CrudMedico : IMedico
    {
        private static List<Medico> medicos = new List<Medico>();
        private static int ProximoId = 1;

        public void Create(Medico model)
        {
            model.Id = ProximoId++;
            medicos.Add(model);

            Console.WriteLine("Médico cadastrado!");
        }

        public List<Medico> Read()
        {
            Console.WriteLine("---------Lista de Médicos---------");
            return medicos;
        }

        public void Update(Medico model)
        {
            Medico? medicoExistente = medicos.Find(x => x.Id == model.Id);

            if (medicoExistente != null)
            {
                medicoExistente.Nome = model.Nome;
                medicoExistente.SobreNome = model.SobreNome;
                medicoExistente.DataNacimento = model.DataNacimento;
                medicoExistente.Documento = model.Documento;
                medicoExistente.Contato = model.Contato;
                medicoExistente.Responsavel = model.Responsavel;
                medicoExistente.genero = model.genero;
                medicoExistente.Cargo = model.Cargo;
                medicoExistente.Turno = model.Turno;
                medicoExistente.Salario = model.Salario;
                medicoExistente.NumeroCrm = model.NumeroCrm;
                medicoExistente.Especialidade = model.Especialidade;

                Console.WriteLine("Médico atualizado!");
            }
            else
            {
                throw new ArgumentException("Médico não encontrado.");
            }
        }

        public void Delete(int id)
        {
            Medico? medico = medicos.Find(x => x.Id == id);

            if (medico != null)
            {
                medicos.Remove(medico);

                Console.WriteLine("Médico removido!");
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }
        }
    }
}
