using System;

public class Veto
{
    public static void Executar()
    {
        int[] notas = new int[5];
        int soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Informe a nota {i + 1}: ");
            notas[i] = int.Parse(Console.ReadLine() ?? "0");
            soma += notas[i];
        }

        Console.WriteLine(soma / (double)notas.Length);
    }
}