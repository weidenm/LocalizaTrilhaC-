using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculosTest
{
    public class CalculoTeste
    {
        [Fact]
        public void Somar_DoisDouble_RetornarDouble()
        {
            var num1 = 10.4;
            var num2 = 5.6;
            var valorEsperado = 16;

            var soma = Calculadora.Calculo.Somar(num1, num2);
            Assert.Equal(valorEsperado, soma);

        }

        [Fact]
        public void Subtrair_DoisDouble_RetornarDouble()
        {
            var num1 = 10.4;
            var num2 = 5;
            var valorEsperado = 5.4;

            var subtrair = Calculadora.Calculo.Subtrair(num1, num2);
            Assert.Equal(valorEsperado, subtrair);

        }
    }
}
