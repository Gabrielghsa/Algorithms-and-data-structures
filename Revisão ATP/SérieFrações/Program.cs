using System;
class Program
{
    static void Main()
    {
        int n; 
        double soma = 0, numerador, denominador;

        Console.Write("Informe o valor de n: ");
        n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n - 1; i++)
        {
            numerador = i;
            denominador = i+1;
            soma += numerador/denominador;
        }
        Console.Write(soma);
    }
}
