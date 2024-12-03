
using Application;

class Program
{
    static void Main(string[] args)
    {
        double radio = 5.0;  
        double altura = 10.0;  

        double perimetro = Circulo.Perimetro(radio);
        double area = Circulo.Area(radio);
        double volumen = PrismaCircular.Volumen(area, altura);

        Console.WriteLine($"El perímetro de la base de un Prisma Circular con radio de {radio}cm es {perimetro}cm");
        Console.WriteLine($"El área de la base de un Prisma Circular con radio de {radio}cm es {area}cm²");
        Console.WriteLine($"El volumen de un Prisma Circular con área de {area}cm² y altura de {altura}cm es {volumen}cm³");
    }
}

