using Biblioteca;

namespace BibliotecaTestes;

[TestFixture]
public class AluguelTeste
{
    BibliotecaClass Biblioteca;

    [SetUp]
    public void Setup()
    {
        this.Biblioteca = new BibliotecaClass();
    }

    [Test]
    public void TestarCadastroLivro()
    {
        Livro livro = new Livro(10, "Livro A", "Autor A", "disponivel");

        bool resultado = Biblioteca.CadastrarLivro(livro);

        Assert.IsTrue(resultado);
    }

    [Test]
    public void TestarCadastroLivroDuplicado()
    {
        Livro livro = new Livro(1, "Crônicas de Nárnia", "Joaozinho", "disponivel");

        bool resultado = Biblioteca.CadastrarLivro(livro);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TestarAluguelLivro()
    {
        bool resultado = Biblioteca.AlugarLivro(1);

        Assert.IsTrue(resultado);
    }

    [Test]
    public void TestarAluguelLivroAlugado()
    {
        bool resultado = Biblioteca.AlugarLivro(2);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TestarDevolucaoLivro()
    {
        bool resultado = Biblioteca.DevolverLivro(2);

        Assert.IsTrue(resultado);
    }
}