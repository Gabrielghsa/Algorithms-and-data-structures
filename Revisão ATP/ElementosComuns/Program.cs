using System;
using System.Runtime.Intrinsics.X86;
class program
{
    static void Main()
    {
        int[] R = new int[5];
        int[] S = new int[5];
        int[] V = new int[R.Length];
        int i, j, k;
        bool jaExiste;

        for (i = 0; i < R.Length; i++)
        {
            Console.Write($"Informe o {i + 1} elemento do vetor R:\n");
            R[i] = int.Parse(Console.ReadLine());
            Console.Write($"Informe o {i + 1} elemento do vetor S:\n");
            S[i] = int.Parse(Console.ReadLine());
        }
        int x = 0;

        for (i = 0; i < R.Length; i++)
        {
            for (j = 0; j < S.Length; j++)
            {
                if (R[i] == S[j])
                {
                    jaExiste = false;

                    for (k = 0; k < x; k++)
                    {
                        if (V[k] == R[i])
                        {
                            jaExiste = true;
                            break;
                        }
                    }

                    if (!jaExiste)
                    {
                        V[x++] = R[i];
                        
                    }
                }
            }
        }

        Console.WriteLine($"Elementos do vetor R: " + string.Join("-", R));
        Console.WriteLine($"Elementos do vetor S: " + string.Join("-", S));

        for (i = 0; i < x; i++)
        {
            Console.Write($" - {V[i]}");
        }

    }
}
