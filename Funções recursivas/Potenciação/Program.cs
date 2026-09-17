using System;
class Program
{
    
    static double Potencia(int num, int expoente)
    {
        //Solução menos eficiente porem com melhor entendimento 
        //O(n)
        if (expoente == 0)
            return 1;

        return num * Potencia(num, expoente - 1);

        /* Solução mais eficiente O(log n)
        double metade = Potencia(num, expoente / 2);
        if (expoente % 2 == 0)
            return Math.Pow(metade, 2);
        return num * Math.Pow(metade, 2);*/
    }

    static void Main(string[] args)
    {
        Console.Write("Qual a base: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Elevado a: ");
        int expo = int.Parse(Console.ReadLine());

        double resultado = Potencia(n, expo);
        Console.WriteLine($"{n}^{expo} = {resultado}");
        Console.ReadKey();
    }
}