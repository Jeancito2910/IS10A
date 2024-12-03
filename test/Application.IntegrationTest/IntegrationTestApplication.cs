using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Fact]
        public void TestCalculoArea()
        {
            double radio = 5.0;
            double area = Circulo.Area(radio);
            Assert.Equal(78.539749999999998, area, 5);
        }

        [Fact]
        public void TestCalculoVolumen()
        {
            double radio = 5.0;
            double altura = 10.0;
            double area = Circulo.Area(radio);
            double volumen = PrismaCircular.Volumen(area, altura);
            Assert.Equal(785.39750000000004, volumen, 5);
        }

        [Fact]
        public void TestPerimetroArea()
        {
            double radio = 5.0;
            double perimetro = Circulo.Perimetro(radio);
            double area = Circulo.Area(radio);
            Assert.True(perimetro > 0 && area > 0);
        }

        [Fact]
        public void TestVolumenNoNegativo()
        {
            double area = 78.53975;
            double altura = 10.0;
            double volumen = PrismaCircular.Volumen(area, altura);
            Assert.True(volumen > 0);
        }

        [Fact]
        public void TestAreaComparacion()
        {
            double radioPequeno = 3.0;
            double radioGrande = 5.0;
            double areaPequena = Circulo.Area(radioPequeno);
            double areaGrande = Circulo.Area(radioGrande);
            Assert.True(areaGrande > areaPequena);
        }
    }
}
