using System;
class Program
{
    static void Main(string[] args)
    {
        // Imprime números de 1 a 10
        int i = 1;

        while (i <= 10)
        {
            Console.Write($"{i,7}");

            i++;
        }

        Console.ReadKey();

        Console.WriteLine("\n");

        i = 1;

        Imprime(i);

        Console.ReadKey();
    }

    //Recursiva
    static void Imprime(int i)
    {
        if (i <= 10)
        {
            Console.Write($"{i,7}");

            Imprime(i + 1);
        }
        Console.ReadKey();
    }

}