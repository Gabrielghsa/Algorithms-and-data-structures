using System;
class Program
{
    static int Potencia(int x,  int y)
    {
        if(y == 1)
            return x;
        return x * Potencia(x, y - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Informe o valor da base: ");
        int xBase = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor do expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        int res = Potencia(xBase, expoente);
        Console.WriteLine($"\nO resultado é ==> {res}");
        Console.ReadKey();
    }
}