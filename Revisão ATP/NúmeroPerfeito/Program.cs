using System;
class Program
{
    static void Main()
    {
        int soma;
        for (int i = 1; i <= 1000; i++)
        {
            soma = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    soma += j;
                }
            }
            if (soma == i)
            {
                Console.Write($"O número {i} é perfeito\n");
            }
        }

    }
}