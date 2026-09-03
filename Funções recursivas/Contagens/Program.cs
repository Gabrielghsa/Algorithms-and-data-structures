using System;
class Program
{
    static void Contagem(int inicio, int final)
    {
        if (inicio == final)
        {
            Console.WriteLine(inicio + " ");
            return;
        }
        Console.Write(inicio + " ");
        Contagem(inicio + 1, final);
    }

    static void ContagemRegre(int inicio)
    {
        if (inicio == 0)
        {
            Console.Write($"{inicio}");
            return;
        }

        Console.Write(inicio + " ");
        ContagemRegre(inicio - 1);
    }

    static void Main(string[] args)
    {
        Contagem(1, 10);
        Console.WriteLine("\n");

        Console.ReadKey();

        ContagemRegre(30);
        Console.ReadKey();
    }
}