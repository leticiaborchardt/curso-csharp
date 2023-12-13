using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBanco;

[TestFixture]
public class ClassTeste
{
    [Test]
    public void StringVazia()
    {
        string vazio = "";

        Assert.IsEmpty(vazio);

        // Assert.IsNotEmpty(vazio)
    }

    [Test]
    public void Maior()
    {
        int n1 = 30;
        int n2 = 10;

        Assert.Greater(n1, n2);
    }

    [Test]
    public void VerificaObjeto()
    {
        Conta c1 = new Conta();
        Conta c2 = new Conta();

        Assert.AreSame(c1, c2);
    }

    [Test]
    public void VerificaNull()
    {
        Conta c1 = new Conta();
        Conta c2 = null;

        Assert.IsNotNull(c1);
        // Assert.IsNull(c2);
    }

    [Test]
    public void VerificaNegativo()
    {
        int n1 = -10;

        Assert.Negative(n1);
    }
}
