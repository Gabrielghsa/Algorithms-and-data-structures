//Vetores
using System;
class program
{
    static void Main()
    {
        int[] A = new int[5];
        int[] B = new int[5];
        int i;
        for(i = 0; i < A.Length; i++)
        {
            Console.Write($"Informe o {i+1} do vetor A: ");
            A[i] = int.Parse(Console.ReadLine());
            Console.Write($"Informe o {i+1} do vetor B: ");
            B[i] = int.Parse(Console.ReadLine());
        }
        
        int contComuns = 0, contDiferentes = 0;
        for(i = 0; i < A.Length; i++)
        {
            bool encontrou = false; 
            for(int j = 0; j < B.Length; j++)
            {
                if(A[i] == B[i])
                {
                    encontrou = true;
                    break;
                }
            }
            if (encontrou)
            {
                contComuns++;
            }else
            {
                contDiferentes++;
            }
        } 

        int[] C = new int[contComuns];
        int[] D = new int[contDiferentes];
        int indiceC = 0;
        int indiceD = 0;

        for(i = 0; i < A.Length; i++){
            bool encontrou = false; 
            for(int j = 0; j < B.Length; j++)
            {
                if(A[i] == B[i])
                {
                    encontrou = true;
                    break;
                }
            }
            if (encontrou)
            {
                C[indiceC] = A[i];
                indiceC++;
            }else
            {
                D[indiceD] = A[i];
                indiceD++;
            }
        }

        
        Console.WriteLine(string.Join(" - ", A));
        Console.WriteLine(string.Join(" - ", B));
        Console.WriteLine(string.Join(" ", C));
        Console.WriteLine(string.Join(" ", D));

    }
}