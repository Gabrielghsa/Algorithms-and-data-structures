using System;
class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10];
        int tamanho = nums.Length;
        Random x = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = x.Next(1, 50);
            Console.Write($" {nums[i]}");
        }

        for (int i = 0; i < tamanho / 2; i++)
        {
            int aux = nums[i];
            nums[i] = nums[tamanho - 1 - i];
            nums[tamanho - 1 - i] = aux;
        }
        Console.WriteLine();
        
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($" {nums[i]}");
        }
        Console.ReadKey();
    }
}