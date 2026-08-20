using System;
class Program
{
    static void Main(string[] args)
    {
        string palavra_a = "fish";
        string palavra_b = "fosh";
        int[,] palavra = new int[palavra_a.Length + 1, palavra_b.Length + 1];
        

        for (int i = 1; i <= palavra_a.Length; i++) {
            for (int j = 1; j <= palavra_b.Length; j++) {
                if (palavra_a[i - 1] == palavra_b[j - 1])
                    palavra[i, j] = palavra[i - 1, j - 1] + 1;
                else
                    palavra[i, j] = 0;

            }

        }
        for (int i = 0; i < palavra.GetLength(0); i++)
        {
            for (int j = 0; j < palavra.GetLength(1); j++)
                Console.Write(palavra[i, j] + "\t");
            Console.WriteLine();
        }

        Console.ReadKey();
   }
}