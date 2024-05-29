using NewTalents;
using System;
using System.ComponentModel;
using Xunit;

namespace NewTalentsTestes
{
    public class CalculadoraTest
    {
        public Calculadora construirClasse()
        {
            string data = "29/05/2024";
            Calculadora calc = new("29/05/2024");

            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 5, 8)]
        public void TestarMetodoSomar(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();
            int resultCalc = calc.somar(val1, val2);
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(20, 2, 18)]
        [InlineData(70, 15, 55)]
        public void TestarMetodoSubtrair(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();
            int resultCalc = calc.subtrair(val1, val2);
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(35, 2, 70)]
        public void TestarMetodoMultiplicar(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();
            int resultCalc = calc.multiplicar(val1, val2);
            Assert.Equal(result, resultCalc);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        [InlineData(100, 2, 50)]
        public void TestarMetodoDividir(int val1, int val2, int result)
        {
            Calculadora calc = construirClasse();
            int resultCalc = calc.dividir(val1, val2);
            Assert.Equal(result, resultCalc);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(15, 0)
            );
        }

        [Fact]
        public void TestarHistoricoCalculadora()
        {
            Calculadora calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(5, 3);
            calc.somar(4, 4);
            calc.somar(9, 6);

            var list = calc.historico();

            Assert.NotEmpty(calc.historico());

            Assert.Equal(3, list.Count);
        }
    }
}