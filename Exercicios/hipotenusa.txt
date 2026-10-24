

public class Hipotenusa
{
    public static void Executar()
    {
        Console.Write("Cateto 1: ");
        double c1 = double.Parse(Console.ReadLine());
        Console.Write("Cateto 2: ");
        double c2 = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(c1 * c1 + c2 * c2));
    }
}