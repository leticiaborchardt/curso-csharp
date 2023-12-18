namespace Biblioteca;

public class BibliotecaClass
{
    public string Nome { get; set; }

    public List<Livro> Livros { get; set; } = new List<Livro>();

    public BibliotecaClass()
    {
        Livros.Add(new Livro(1, "Crônicas de Nárnia", "Joaozinho", "disponivel"));
        Livros.Add(new Livro(2, "Harry Potter", "JK", "alugado"));
        Livros.Add(new Livro(3, "Testes Teste", "Teste", "disponivel"));
    }

    public bool CadastrarLivro(Livro livro)
    {
        Livro? livroExistente = Livros.FirstOrDefault(l => l.Codigo == livro.Codigo);

        if (livroExistente != null)
        {
            return false;
        }

        this.Livros.Add(livro);
        
        return true;
    }

    public bool AlugarLivro(int codigo)
    {
        Livro? livro = this.Livros.FirstOrDefault(l => l.Codigo == codigo);

        if (livro != null && livro.Status == "disponivel")
        {
            livro.Status = "alugado";
            return true;
        }
        
        return false;
    }

    public bool DevolverLivro(int codigo)
    {
        Livro? livro = this.Livros.FirstOrDefault(l => l.Codigo == codigo);

        if (livro != null && livro.Status == "alugado")
        {
            livro.Status = "disponivel";
            return true;
        }
        
        return false;
    }
}
