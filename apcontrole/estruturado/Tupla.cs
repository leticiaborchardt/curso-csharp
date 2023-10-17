using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apcontrole.estruturado
{
    public class Tupla
    {
        public void ExecutarTupla()
        {
            // Dados imutáveis e precisam ser modificados através de variáveis.
            var pessoa = (nome: "letícia", idade: 18, cidade: "Timbó", tipoSanguineo: 'O');

            string nomeDaPessoa = pessoa.nome;
            int idadeDaPessoa = pessoa.idade;
            string cidadeDaPessoa = pessoa.cidade;
            char tipoSanguineoDaPessoa = pessoa.tipoSanguineo;

            Console.WriteLine($"Nome: {nomeDaPessoa}");
            Console.WriteLine($"Idade: {idadeDaPessoa}");
            Console.WriteLine($"Cidade: {cidadeDaPessoa}");
            Console.WriteLine($"Tipo Sanguíneo: {tipoSanguineoDaPessoa}");
        }
    }
}