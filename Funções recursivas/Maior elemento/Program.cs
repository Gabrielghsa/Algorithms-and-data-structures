using System;
class Program
{
    static int Maior(int[] vetor, int indice)
    {
        if (indice == vetor.Length - 1)
            return vetor[indice];
        int maiorElemento = Maior(vetor, indice + 1);
        return Math.Max(vetor[indice], maiorElemento);

    }

    static void MostraMaior(int maiorElemento)
    {
        Console.WriteLine($"O maior elemento do vetor é: {maiorElemento}");
    }

    static void Main(string[] args)
    {
        int[] nums = { 4, 14, 21, 8, 15, 88, 100, 77, 23 };
        int maiorNum = Maior(nums, 0);
        MostraMaior(maiorNum);
        Console.ReadLine();
    }
}