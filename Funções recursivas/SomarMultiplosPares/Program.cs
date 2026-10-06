using System;
class Program
{
    static int SomaMultiplosPares(int inicio, int fim)
    {
        if(inicio > fim)
            return 0;
        if (inicio % 2 == 0 && inicio % 4 == 0)
            return inicio + SomaMultiplosPares(inicio + 1, fim);
       
        return SomaMultiplosPares(inicio + 1, fim);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o início: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o fim: ");
        int fim = int.Parse(Console.ReadLine());

        int res = SomaMultiplosPares(inicio, fim);
        Console.WriteLine($"\nO resultado é ==> {res}");
        Console.ReadKey();
    }
}