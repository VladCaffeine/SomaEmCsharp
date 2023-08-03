using System;

public class Calculadora
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um valor: ");
        int ValorX = int.Parse(Console.ReadLine());

        Console.Write("Digite um segundo valor: ");
        int ValorY = int.Parse(Console.ReadLine());

        int resultado = ValorX + ValorY;
        Console.WriteLine($"Resultado igual a: {resultado}");
    }
}
