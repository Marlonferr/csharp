

class learning

{


    public static void Executar()
    {
         double A, B, C;
     
        double tri, cir, trap, quad, reta;
      string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);
        tri = A * C / 2.0;
         cir = 3.14159 * C * C;
        trap = (A + B) / 2.0 * C;
        quad = B * B;
        reta = A * B;
        Console.WriteLine("TRIANGULO: " + tri.ToString("F3"));
Console.WriteLine("CIRCULO: " + cir.ToString("F3"));
Console.WriteLine("TRAPEZIO: " + trap.ToString("F3"));
Console.WriteLine("QUADRADO: " + quad.ToString("F3") );
Console.WriteLine("RETANGULO: " + reta.ToString("F3"));

    }
}