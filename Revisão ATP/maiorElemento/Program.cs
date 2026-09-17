using System;
class Program
{
    static int maiorElemento(int[] vetor)
    {
        int maior = vetor[0];
        for (int i = 1; i < vetor.Length; i++)
            if (vetor[i] > maior)
                maior = vetor[i];
        return maior;
    }
        
    static void Main(string[] args)
    {
        int[] numeros = new int[10] { 1, 2, 89, 4, 5, 6, 99, 8, 9, 100 };
        int maiorElementoVetor = maiorElemento(numeros);
        Console.Write($"O maior elemento é: {maiorElementoVetor}");
        Console.ReadKey();
    }
}
