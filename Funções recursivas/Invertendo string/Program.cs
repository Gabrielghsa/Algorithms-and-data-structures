using System;
class Program
{
    static string InvertePalavra(string palavra)
    {

        if (palavra.Length <= 1)
           return palavra;

        else
            return palavra[palavra.Length - 1] + InvertePalavra(palavra.Substring(0, palavra.Length - 1));
    }

        static void Main(string[] args)
        {
            string palavra;
            Console.Write("Escreva qual palavra você quer inverter: ");
            palavra = Console.ReadLine();

            Console.Write(InvertePalavra(palavra));
            Console.ReadLine();
        }  
}