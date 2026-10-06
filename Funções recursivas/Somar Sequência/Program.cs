using System;
class Program
{
    static int SomaSequencia(int x)
    {
        if (x == 1)
            return 1;
        return x + SomaSequencia(x - 1);
        
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Até que número a soma deverá acontecer? ");
        int num = int.Parse(Console.ReadLine());

        int somaSeq = SomaSequencia(num);
        Console.WriteLine($"\nO resultado é ==> {somaSeq}");
        Console.ReadKey();
    }
}