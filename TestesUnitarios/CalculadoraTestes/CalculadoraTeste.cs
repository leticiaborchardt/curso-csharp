using Calculadora;

namespace CalculadoraTestes;

public class CalculadoraTeste
{
    public void TestarSoma(int a, int b)
    {
        ClassCalculadora calculadora = new ClassCalculadora();

        if (a < 0 || b < 0)
        {
            Console.WriteLine("Erro: Não é possível somar números negativos. Para isso, utilize a função subtrair.");
        }
        else
        {
            int resultadoEsperado = a + b;
            int resultado = calculadora.Somar(a, b);

            VerificarResultado("Soma", resultado, resultadoEsperado);
        }
    }

    public void TestarSubtracao(int a, int b)
    {
        ClassCalculadora calculadora = new ClassCalculadora();

        if (b > a)
        {
            Console.WriteLine("Erro: o segundo número deve ser menor que o primeiro");
        }
        else if (a == 0)
        {
            Console.WriteLine("Erro: o primeiro número não pode ser 0");
        }
        else
        {
            int resultadoEsperado = a - b;
            int resultado = calculadora.Subtrair(a, b);

            VerificarResultado("Subtração", resultado, resultadoEsperado);
        }

    }

    public void TestarMultiplicacao(int a, int b)
    {
        ClassCalculadora calculadora = new ClassCalculadora();

        // Verificar multiplicação resultando em overflow de int
        // A condição a seguir verifica se a multiplicação resultará em overflow:
        // 1. (b != 0 && a > int.MaxValue / b): quando 'b' não é zero e 'a' é maior que o quociente máximo de int.MaxValue / b.
        // 2. (a == int.MinValue && b == -1): quando 'a' é int.MinValue e 'b' é -1, o qual resulta em overflow.
        if ((b != 0 && a > int.MaxValue / b) || (a == int.MinValue && b == -1))
        {
            Console.WriteLine("Erro: Multiplicação resulta em overflow de int.");
        }
        else
        {
            int resultadoEsperado = a * b;
            int resultado = calculadora.Multiplicar(a, b);

            VerificarResultado("Multiplicação", resultado, resultadoEsperado);
        }
    }

    public void TestarDivisao(int a, int b)
    {
        ClassCalculadora calculadora = new ClassCalculadora();

        if (b == 0)
        {
            Console.WriteLine("Erro: não é possível realizar divisão por 0");
        }
        else if (a < 0 || b < 0)
        {
            Console.WriteLine("Erro: os números devem ser positivos para a divisão.");
        }
        else
        {
            int resultadoEsperado = a / b;
            int resultado = calculadora.Dividir(a, b);

            VerificarResultado("Divisão", resultado, resultadoEsperado);
        }
    }

    public void VerificarResultado(string operacao, int resultado, int resultadoEsperado)
    {
        Console.WriteLine($"Resultado da operação {operacao}: {resultado}");

        if (resultado == resultadoEsperado)
        {
            Console.WriteLine($"Resultado da operação {operacao} está correto!");
        }
        else
        {
            Console.WriteLine($"Resultado da operação {operacao} está errado.");
        }
    }
}
