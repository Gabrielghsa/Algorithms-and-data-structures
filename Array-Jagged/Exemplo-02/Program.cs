using System;



class Program
{
    static void Main(string[] args)
    {
        //Array {0, 1, 2, 3} um array nomral com 4 elementos
        //jaggedArray {0[0,1,2], 1[0,1,2], 2[0,1,2]} jagged é um array de arrays, e cada array pode ter seu tamanho 

        int[][] jaggedArray = new int[4][];
        jaggedArray[0] = new int[] { 1, 2, 3, };
        jaggedArray[1] = new int[] { 4, 5, 6, 7 };
        jaggedArray[2] = new int[] { 8 };
        jaggedArray[3] = new int[] { 9, 10 };

        Console.WriteLine(jaggedArray[0][2]);
        Console.WriteLine(jaggedArray[1][0]);
        Console.WriteLine(jaggedArray[2][0]);
        Console.WriteLine(jaggedArray[3][1]);
        Console.ReadKey();

        int[][] arrayJagged = new int[][]
        {
            new int[] {1, 2, 3, 4, 5},
            new int[] {6, 7,},
            new int[] {8, 9 ,10}
        };
        Console.WriteLine("For loop in arrayJagged: ");
        for(int i = 0; i < arrayJagged.Length; i++)
        {
            Console.WriteLine($"index {i}");
            for(int j = 0; j < arrayJagged[i].Length; j++)
            {
                Console.WriteLine($"{arrayJagged[i][j]}");
                
            }
        }
        Console.ReadKey();

    }
}
