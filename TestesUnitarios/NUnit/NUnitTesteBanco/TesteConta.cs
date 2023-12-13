using BancoTeste;

namespace NUnitTesteBanco;

[TestFixture]
public class TesteConta
{
    [Test]
    public void TestarSaque()
    {
        Conta conta = new Conta("123", 500);

        bool resultado = conta.Sacar(300);

        Assert.IsTrue(resultado);

        Assert.Pass();
    }

    [Test]
    public void TestarSaqueSemSaldo()
    {
        Conta conta = new Conta("123", 0);

        bool resultado = conta.Sacar(1000);

        Assert.IsFalse(resultado);

        Assert.Pass();
    }

    [Test]
    public void TestarDeposito()
    {
        Conta conta = new Conta("123", 500);

        bool resultado = conta.Depositar(300);

        Assert.IsTrue(resultado);

        Assert.Pass();
    }
}