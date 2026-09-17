using System;
class Program
{
    static void Main(string[] args)
    {
        //Somando arrayJagged
        int qtdLinhas, qtdElementos, somaTotal = 0, somaLinha;
        

        Console.Write("Informe a quantidade de linhas: ");
        qtdLinhas = int.Parse(Console.ReadLine());
        int[][] nums = new int[qtdLinhas][];
        int[] somaLinhas = new int[qtdLinhas];

        for (int i = 0; i < qtdLinhas; i++) {
            Console.Write("Informe a quantidade de números: ");
            qtdElementos = int.Parse(Console.ReadLine());
            nums[i] = new int[qtdElementos];
            somaLinha = 0;

            for (int j = 0; j < qtdElementos; j++) {
                Console.Write($"Informe o {j + 1}° número da {j + 1}° linha: ");
                nums[i][j] = int.Parse(Console.ReadLine());
                somaTotal += nums[i][j];
                somaLinha += nums[i][j];
            }
            somaLinhas[i] = somaLinha;
        }

        for (int i = 0; i < nums.Length; i++) {
            Console.Write($"Linha {i + 1}: ");
            Console.WriteLine($"A soma da linha {i + 1} é: {somaLinhas[i]}");
            for (int j = 0; j < nums[i].Length; j++) {
                Console.WriteLine($"       ==> {nums[i][j]}");
            }
        }
        Console.WriteLine($"A soma dos elementos é: {somaTotal}");
        
        Console.ReadKey();
    }
}