using System;
class Program
{
    static void ImprimeR(string F, int valorAtual, int nRVezes)
    {
        if (valorAtual <= nRVezes)
        {
            Console.WriteLine($"{F} {valorAtual}");
            ImprimeR(F, ++valorAtual, nRVezes);
        }

    }
    static void Main(string[] args)
    {
        int n;
        string Frase;

        Console.Write("Frase para Impressão...: ");
        Frase = Console.ReadLine();

        Console.Write("Quantidade de vezes....: ");
        n = int.Parse(Console.ReadLine());

        ImprimeR(Frase, 1, n);
        Console.ReadKey();

    }
}