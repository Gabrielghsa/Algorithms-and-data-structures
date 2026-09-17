using System;
class Program
{
    static void Main(string[] args)
    {
        int posIns = 0;
        
        int[] R = new int[10];
        int[] S = new int[10];
        int[] V = new int[20];
        bool existe;
        for(int i = 0; i < R.Length; i++)
        {
            Console.Write($"Informe o {i + 1}° elemento de R: ");
            R[i] = int.Parse(Console.ReadLine());
            V[posIns++] = R[i];
        }
        for (int i = 0; i < S.Length; i++)
        {
            Console.Write($"Informe o {i + 1}° elemento de S: ");
            S[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < S.Length; i++)
        {
            existe = false;
            for (int j = 0; j < posIns; j++) {
                if (S[i] == V[j])
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                V[posIns++] = S[i];
            }  
        }
        Console.Write("A união dos vetores R e S é:");
        for (int i = 0; i < V.Length; i++) {
            Console.Write($" - {V[i]}");
        }
        Console.ReadKey();
    }
}