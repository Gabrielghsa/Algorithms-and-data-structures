using System; 
class program
{
    static void Main()
    {
        int i, n, resultado = 1000;

        Console.Write("Informe o valor de n:\n ");
        n = int.Parse(Console.ReadLine()); 

        for(i = 1; i <= n; i++)
        {
            if(i % 2 == 0)
                resultado -= i;
            
            else 
                resultado += i;
            
        }
        Console.Write($"O reusltado da série é: {resultado}");

    }
}