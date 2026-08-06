using System; 
class program
{
    static void Main()
    {
        int a = 5, b = 3;
        double r;
        r = ++a * --b;
        Console.WriteLine($"{r}");
        r = (a -= 2) * 7 / --b;
        Console.WriteLine($"{r}");
        r = a %= 2 * b;
        Console.Write($"{r}");

    }
}
