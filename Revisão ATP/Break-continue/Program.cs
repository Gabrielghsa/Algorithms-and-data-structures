using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            if ((i + 5) == 10)
                break;
        }
        Console.Write("break executado ");
        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
        {
            
            if ((i + 5) == 10)
                continue;  //continue faz a iteração atual ser interrompida e pula direto para a próxima. Nesse if o número 5 não sera exibido pq ele faz o if ser true
            Console.WriteLine(i);
        }
       

        Console.ReadKey();

    }
}