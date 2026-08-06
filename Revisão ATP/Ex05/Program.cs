using System;
class program
{
    static void Main()
    {
        int[,] m = new int[5, 3];
        int i, j;
        for (i = 0; i < m.GetLength(0); i++)
        {
            for (j = 0; j < m.GetLength(1); j++)
            {
                Random x = new Random();
                int numRandon = x.Next(1, 51);
                m[i, j] = numRandon; 
            }
        }

        int somaLinha;

        for (i = 0; i < m.GetLength(0); i++)
        {
            somaLinha = 0;
            for (j = 0; j < m.GetLength(1); j++)
            {
                somaLinha += m[i, j];
            }
            Console.WriteLine($"A soma da linha {i} é: {somaLinha}");
        }
    }
}