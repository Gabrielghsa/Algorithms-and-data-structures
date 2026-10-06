using System;
class Program
{
    static int fibonaci(int n)
    {
        if(n == 1)
            return 0;
        if(n == 2)
            return 1;
        return fibonaci(n - 1) + fibonaci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(fibonaci(5));
        Console.ReadKey();
    }
}