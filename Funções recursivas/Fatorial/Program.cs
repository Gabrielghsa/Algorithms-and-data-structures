using System;
class Program
{
    static int Fatorial(int n)
    {
        if(n == 0)
        {
            return 1;
        }
        return n * Fatorial(n - 1);
    }

    static void ExibeFatorial(int n)
    {
        Console.Write($"\nO fatorial de {n} é: {Fatorial(n)}");
    }

    static void Main(string[] args)
    {
        Console.Write("Informe qual o número você deseja saber o fatorial:\n\n");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)

            ExibeFatorial(n);
        else
            Console.Write("Digite um número não negativo!");
        Console.ReadKey();
    }
    
}