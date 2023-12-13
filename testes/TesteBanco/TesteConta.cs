using Banco;

namespace TesteBanco;

[TestFixture]
public class TesteConta
{
    Conta conta;

    [SetUp]
    public void Setup()
    {
        conta = new Conta("090.989.458-12", 1000);
    }

    [Test]
    public void TestarSaque()
    {
        bool resultado = conta.Sacar(300);

        Assert.IsTrue(resultado);

        Assert.Pass();
    }

    [Test]
    public void TestarSaqueSemSaldo()
    {
        bool resultado = conta.Sacar(1000);

        Assert.IsFalse(resultado);

        Assert.Pass();
    }

    [Test]
    [Ignore("Pendência de implementação de retorno false para saques negativos.")]
    public void TestarSaqueNegativo()
    {
        bool resultado = conta.Sacar(-200);

        Assert.IsFalse(resultado);
    }

    [Test]
    public void TestarDeposito()
    {
        bool resultado = conta.Depositar(300);

        Assert.IsTrue(resultado);

        Assert.Pass();
    }
}