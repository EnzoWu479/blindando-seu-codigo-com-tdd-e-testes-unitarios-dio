using NewTalents.Services;

namespace NewTalents.Teste;

public class UnitTest1
{
    Calculadora _calculadora;

    public UnitTest1()
    {
        _calculadora = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 5)]
    public void TesteSomar(int a, int b, int c)
    {

        // Act 
        int resultado = _calculadora.Somar(a, b);

        // Assert
        Assert.Equal(c, resultado);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(8, 2, 6)]
    [InlineData(3, 2, 1)]
    public void TesteSubtrair(int a, int b, int result) {
        // Act
        int resultado = _calculadora.Subtrair(a, b);

        // Assert
        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(3, 2, 6)]
    public void TesteMultiplicar(int a, int b, int result) {
        // Act
        int resultado = _calculadora.Multiplicar(a, b);

        // Assert
        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(2, 2, 1)]
    [InlineData(3, 2, 1)]
    public void TesteDividir(int a, int b, int result) {
        // Act
        int resultado = _calculadora.Dividir(a, b);

        // Assert
        Assert.Equal(result, resultado);
    }

    [Fact]
    public void TesteDivisaoPorZero() {
        // Arrange
        int a = 1;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException >(
            () => _calculadora.Dividir(a, b)
        );
    }

    [Fact]
    public void TesteHistorico() {

        Calculadora calculadora = new Calculadora();

        // Arrange
        List<string> historico = new List<string>();

        calculadora.Somar(1, 2);
        calculadora.Subtrair(1, 2);
        calculadora.Multiplicar(1, 2);
        calculadora.Dividir(1, 2);
         

        // Act
        historico = calculadora.Historico();

        // Assert
        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
    }
}