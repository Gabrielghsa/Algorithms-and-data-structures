using System;
class Program
{
    static int MDC(int x, int y)
    {
        if (y == 0)
            return x;
        return MDC(y, x % y);

    }

    static void Main(string[] args)
    {
        int res = MDC(24, 18);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}