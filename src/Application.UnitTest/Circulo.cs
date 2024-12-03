using System;
using Xunit;
using Application;

namespace Application.UnitTest
{
    public class UnitTestCirculo
    {
        // Pruebas para el Perímetro
        [Theory]
        [InlineData(3, 18.84956)] // Perímetro = 2 * π * radio
        [InlineData(4, 25.13272)]
        [InlineData(5, 31.41593)]
        [InlineData(6, 37.69911)]
        [InlineData(7, 43.98230)]
        public void TestPerimetro(double radio, double perimetroEsperado)
        {
            // Act - Realizar
            double resultado = Circulo.Perimetro(radio);

            // Assert - Verificar
            Assert.Equal(perimetroEsperado, resultado, 5); // Tolerancia de 5 decimales
        }

        // Pruebas para el Área
        [Theory]
        [InlineData(3, 28.27433)] // Área = π * radio^2
        [InlineData(4, 50.26544)]
        [InlineData(5, 78.53975)]
        [InlineData(6, 113.0976)]
        [InlineData(7, 153.93804)]
        public void TestArea(double radio, double areaEsperada)
        {
            // Act - Realizar
            double resultado = Circulo.Area(radio);

            // Assert - Verificar
            Assert.Equal(areaEsperada, resultado, 5); // Tolerancia de 5 decimales
        }
    }
}
