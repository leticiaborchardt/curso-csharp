using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca;

public class Livro
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Autor { get; set; }
    public string Status { get; set; }

    public Livro(int codigo, string nome, string autor, string status)
    {
        this.Codigo = codigo;
        this.Nome = nome;
        this.Autor = autor;
        this.Status = status;
    }
}
