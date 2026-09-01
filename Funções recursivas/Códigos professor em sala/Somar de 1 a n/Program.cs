using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int x;
        int Result;

        Console.Write("x = ");
        x = int.Parse(Console.ReadLine());

        Result = SomaN(i, x);

        Console.WriteLine($"\nSoma = {Result}");

        Console.ReadKey();

        Result = SomaR(i, x);

        Console.WriteLine($"\nSoma = {Result}");

        Console.ReadKey();

    }

    static int SomaN(int VInicial, int VFinal)
    {
        int R = 0;

        for (int i = VInicial; i <= VFinal; i++)
            R += i;

        return R;
    }

    static int SomaR(int VInicial, int VFinal)
    {
        int R = VInicial;

        if (VInicial < VFinal)
            return R + SomaR(VInicial + 1, VFinal);
        else
            return R;
    }
}
