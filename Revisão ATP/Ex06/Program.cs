using System; 
class program
{

    static int fatorial(int x)
    {
        int i, fat = 1;
        for(i = 1; i <= x; i++)
        {
            fat = fat * i;
        }
        return fat;
    }

    static double potencia(int x, int y)
    {
        return Math.Pow(x,y);
    }
    static void Main()
    {
        int fat = fatorial(3);
        Console.WriteLine(fat);
        double pot = potencia(2,5);
        Console.WriteLine(pot);
    }
}