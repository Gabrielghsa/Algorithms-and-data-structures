using System;
class Program
{
    static int Fibonacci(int n)
    {
        if(n == 1)
            return 0;
        else if(n == 2)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }


    static void Main(string[] args)
    {
        Console.Write("Digite qual a posição na sequência você quer:\n\n");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            Console.Write($"\nO valor da posição {n} na sequência de Fibonacci é: {Fibonacci(n)}");
        else
            Console.Write("Informe um valor maior que zero");
        Console.ReadKey();
    }
} 