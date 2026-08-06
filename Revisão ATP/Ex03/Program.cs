//Número primo 
using System;
using System.Collections.Generic;
using System.Linq;
class program
{
    static void Main()
    {
        int n, i;
        Console.Write("Informe um número: ");
        n = int.Parse(Console.ReadLine());

        List<int> nums = new List<int>();
        for(i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                nums.Add(i);
            }

        }       
        string status = nums.Count == 2 ? "É Primo" : "Não é Primo";
        Console.WriteLine(status);

        Console.WriteLine(string.Join(" ", nums));
    }
}