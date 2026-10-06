using System;
class Program
{

    static double SomaTermos(int n)
    {
        if(n == 0)
            return 0;
        return (double)n / (n + 1) + SomaTermos(n - 1);
    }


    static void Main(string[] args)
    {
        double res = SomaTermos(4);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}