using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsackNewton.Data;
using IsacNewton.Service.SalaService.Interface;

namespace IsacNewton.Service.SalaService.Implements
{
    public class CrudSala : ISala
    {
        private static List<Sala> Salas { get; set; }
        private int Id;

        public CrudSala()
        {
            Salas = new List<Sala>();
        }
        
        public void Create(Sala model)
        {
            try
            {
                model.Id = Id++;
                Salas.Add(model);
                Console.WriteLine("Sala criada com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Sala> Read()
        {
            Console.WriteLine("---------Lista de Salas---------");
            return Salas;
        }

        public void Update(Sala model)
        {
            try
            {
                foreach (var sala in Salas)
                {
                    if (sala.Id == model.Id)
                    {
                        sala.Numero = model.Numero;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                foreach (var sala in Salas)
                {
                    if (sala.Id == id)
                    {
                        Salas.Remove(sala);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
