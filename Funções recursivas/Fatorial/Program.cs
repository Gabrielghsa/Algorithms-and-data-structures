using System;
class Program
{
    static long Fatorial(long n)
    {
        if(n == 0)
        {
            return 1;
        }
        return n * Fatorial(n - 1);
    }

    static void ExibeFatorial(long n)
    {
        Console.Write($"\nO fatorial de {n} é: {Fatorial(n)}");
    }

    static void Main(string[] args)
    {
        Console.Write("Informe qual o número você deseja saber o fatorial:\n\n");
        if (long.TryParse(Console.ReadLine(), out long n) && n >= 0)

            ExibeFatorial(n);
        else
            Console.Write("Digite um número não negativo!");
        Console.ReadKey();
    }
    
}