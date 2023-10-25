using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apcontrole.Interfaces.Escola.Models;
using apcontrole.Interfaces.Escola.Services;

namespace apcontrole.Interfaces.Escola.Views
{
    public class View
    {
        public void Main()
        {
            // Rotina de cadastros da escola
            do
            {
                Console.WriteLine("O que você deseja cadastrar? (professor / aluno / materia / turma)");
                string tipoCadastro = Console.ReadLine();

                switch (tipoCadastro)
                {
                    case "professor":
                        CrudProfessor crudProfessor = new CrudProfessor();
                        crudProfessor.Create();


                        break;
                    default:
                }


            } while (Continuar());
        }

        private bool Continuar()
        {
            Console.WriteLine("Você deseja continuar cadastrando? (s/n)");

            string continuar = Console.ReadLine().ToLower();

            return continuar == "s";
        }
    }
}