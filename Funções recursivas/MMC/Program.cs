using System;
class Program
{
    static int MMC(int n, int m, int i)
    {
        if (i % n == 0 && i % m == 0)
            return i;
        return MMC(n, m, i+1);
    }

    static void Main(string[] args)
    {
        int res = MMC(120, 216, 1);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}