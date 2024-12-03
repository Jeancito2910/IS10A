using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestPrismaCircular
    {
        // Pruebas para el Volumen
        [Theory]
        [InlineData(3.14159, 4, 50.26544)] // Volumen = Área * Altura
        [InlineData(3.14159, 6, 113.0976)]
        [InlineData(3.14159, 10, 314.159)]
        [InlineData(3.14159, 12, 452.38934)]
        [InlineData(3.14159, 15, 706.8583)]
        public void TestVolumen(double pi, double radio, double volumenEsperado)
        {
            // Act - Realizar
            double resultado = PrismaCircular.Volumen(areaEsperada, radio);

            // Assert - Verificar
            Assert.Equal(volumenEsperado, resultado, 5); // Tolerancia de 5 decimales
        }
    }
}
