using System;
class Program
{
    static int MultiplicacaoRussa(int x, int y)
    {
        if (x == 0)
            return 0;
        if (x % 2 == 0)
            return 0 + MultiplicacaoRussa(x / 2, y * 2);
        else
            return y + MultiplicacaoRussa(x / 2, y * 2);
    }

    static void Main(string[] args)
    {
        int res = MultiplicacaoRussa(27, 18);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}