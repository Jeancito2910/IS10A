namespace Application;
public class Circulo
{
    public static double Perimetro(double radio)
    {
        double perimetro = 2 * Math.PI * radio;
        return perimetro;
    }

    public static double Area(double radio)
    {
        double area = Math.PI * radio * radio;
        return area;
    }
}
