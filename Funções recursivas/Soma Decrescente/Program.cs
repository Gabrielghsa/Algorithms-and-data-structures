using System;
class Program
{
    static int SomaDecrescente(int n)
    {
        if(n == 1)
            return 0;
        if (n % 2 == 0)
            return n + SomaDecrescente(n - 1);
        return SomaDecrescente(n - 1);
    }

    static void Main(string[] args)
    {
        int res = SomaDecrescente(8);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}