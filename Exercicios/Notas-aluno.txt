using System;

class notas

{


    public static void Executar()
    {

        Console.WriteLine("digite seu nome, sua idade e seu produto: ");
        string[] nome = Console.ReadLine().Split(" ");
        int idade = int.Parse(nome[1]);
        Console.WriteLine($"Seu ultimo nome é {nome[0]}, sua idade é {idade} seu produto é {nome[2]} ");



    }
}