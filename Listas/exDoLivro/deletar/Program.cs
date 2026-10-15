//Deletar um elemento qualquer do array sem mover o resto do array para esquerda ou direita.
//Apenas mudar de lugar a posição a ser deletada com a última posição

using System;
class P1rogram
{

    static int Deletar(int[] xVetor, int posicao, int qtd)
    {
        if(qtd == 0)
            Console.WriteLine("Vetor vázio!");
        else if(posicao < 0 || posicao >= qtd)
            Console.WriteLine($"Posição {posicao} está fora do limite do vetor!");
        else
        {
            xVetor[posicao] = xVetor[qtd - 1];
            qtd--;
        }
        return qtd;
    }

    static void BuscarElemento(int[] xVetor, int nProcurado, int qtd)
    {
        for (int i = 0; i < qtd; i++)
            if (xVetor[i] == nProcurado)
                Console.WriteLine($"Valor encontrado no índice {i}\n");
    }

   
    static void MaiorEMenor(int[] xVetor, int qtd)
    {
        int minValue = xVetor[0];
        int maxValue = xVetor[0];
        int posicaoMin = 0;
        int posicaoMax = 0;
        for (int i = 1; i < qtd; i++)
        {
            if (xVetor[i] < minValue)
            {
                minValue = xVetor[i];
                posicaoMin = i;
            }

            if(xVetor[i] > minValue)
            {
                maxValue = xVetor[i];
                posicaoMax = i;
            }
        }

        Console.WriteLine($"O menor elemento é {minValue} na posição {posicaoMin}\n");
        Console.WriteLine($"O maior elemento é {maxValue} na posição {posicaoMax}\n");
    }

    static void Main(string[] args)
    {
        int[] vetor = new int[10] { 1, 2, 4, 6, 3, 12, 13, 0, 0, 0 };
        int qtd = 7;
        

        qtd = Deletar(vetor, 1, qtd);

        BuscarElemento (vetor, 10, qtd);

        MaiorEMenor(vetor, qtd);

        for(int i  = 0; i < qtd; i++)
            Console.Write($"{vetor[i]}  ");

        Console.ReadKey();
    }
}