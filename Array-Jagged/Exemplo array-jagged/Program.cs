using System;
class Program
{
    static void Main(string[] Args)
    {
        // Exemplo de Array Jagged
        // Possui uma dimensão fixa e outra que pode ser variável
        // (como uma matriz em que a segunda dimensão é um vetor de tamanho variável)

        // int[][] MJagged = new int[3][];

        // MJagged[0] = new int[] { 0, 1, 2, 3 };
        // MJagged[1] = new int[] { 4, 5, 6, 7, 8, 9 };
        // MJagged[2] = new int[] { 10, 20 };

        int NúmeroDeTurmas;
        int NúmeroDeAlunos = 0;

        Console.Write("Informe o Número de Turmas: ");
        NúmeroDeTurmas = int.Parse(Console.ReadLine());

        string[][] Turmas = new string[NúmeroDeTurmas][];           // Declaração da primeira dimensão...

        for (int i = 0; i < NúmeroDeTurmas; i++)
        {
            Console.Write("\nQuantidade de Alunos da Turma {0}: ", i + 1);
            NúmeroDeAlunos = int.Parse(Console.ReadLine());

            Turmas[i] = new string[NúmeroDeAlunos];                 // Declaração da segunda dimensão...

            for (int j = 0; j < NúmeroDeAlunos; j++)
            {
                Console.Write("   Informe o Nome do Aluno {0}: ", j + 1);
                Turmas[i][j] = Console.ReadLine();
            }
        }

        // Listagem
        for (int i = 0; i < Turmas.GetLength(0); i++)
        {
            Console.WriteLine("\nTurma {0}", i + 1);

            for (int j = 0; j < Turmas[i].GetLength(0); j++)        // Macete...
            {
                Console.WriteLine("     ==> {0}", Turmas[i][j]);
            }
        }

        Console.ReadKey();
    }

}
