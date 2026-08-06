//Número perfeito

using System; 
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        
        int i, soma;
        for(i = 1; i <= 1000; i++)
        {
            List<int> divisores = new List<int>();
            for(int j = 1; j < i; j++)
            {
                if(i % j == 0)
                {
                    divisores.Add(j);
                }
            }
            soma = divisores.Sum();
            if(soma == i)
            {
                Console.WriteLine(i);
            }
        }


    }
}