//Exemplo com FOR
using System;
class program
{
    static void Main()
    {
        ConsoleKeyInfo resp;
        Random x = new Random();
        Console.WriteLine("Sequência de números aleatórios: ");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Sorteio {0:00}: {1,10}", i, x.Next());
        }
        Console.ReadKey();


        //Exemplo com FOREACH
        Console.WriteLine();
        Console.WriteLine("Exemplo com ForEach");
        string[] frase = new string[] { "SI", "ST", "EM", "AS", " D", "E ", "IN", "FO", "RM", "AÇ", "ÃO" };
        foreach (string letras in frase)
        {
            Console.Write(letras);
        }
        Console.ReadKey();
        Console.WriteLine();

        //Exemplo com While
        Console.WriteLine();
        Console.WriteLine("Exemplo com While");

        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine("Sorteio {0:00}: {1,10}", j, x.Next());
            j++;
        }
        Console.ReadKey();
        Console.WriteLine();

        //Exemplo com DO While
        Console.WriteLine("Exemplo com DO While");
        int k = 1;
        do
        {
            Console.WriteLine("Sorteio {0:00}: {1,10}", k, x.Next());
            k++;
            Console.Write("\t\tDeseja um outro Número? (S/N) ");
            resp = Console.ReadKey();
        }while (resp.KeyChar == 'S' || resp.KeyChar == 's');
    }
}

