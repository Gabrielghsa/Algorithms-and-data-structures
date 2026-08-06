using System;
class program
{
    static void Main()
    {
        double x, y, resul;

        Console.Write("Informe o valor de x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor de y: ");
        y = double.Parse(Console.ReadLine());

        
        resul = Math.Sqrt(x+y) / (2*x) + x / (2*y);
        Console.WriteLine($"O resultado é: {resul:f2}");

    }
}