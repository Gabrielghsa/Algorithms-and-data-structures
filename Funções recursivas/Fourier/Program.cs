using System;
class Program
{
    static void Main()
    {
        long n;
        long nTermo;

        Console.Write("Digite o Termo da Série: ");
        n = long.Parse(Console.ReadLine());

        nTermo = CalcFibonacciI(n);

        Console.WriteLine($"\nO termo {n} da Série de Fibonacci é {nTermo}");

        Console.ReadKey();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i,3} = {CalcFibonacciR(i)}");
        }

        Console.ReadKey();
    }

    static long CalcFibonacciR(long n)
    {
        if (n < 2)
            return n;
        else
            return CalcFibonacciR(n - 1) + CalcFibonacciR(n - 2);
    }
    static long CalcFibonacciI(long n)
    {
        int Atual = 0;
        int Ant = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Atual = 1;
                Ant = 0;
            }
            else
            {
                Atual += Ant;
                Ant = Atual - Ant;
            }
        }

        return Atual;
    }
}
