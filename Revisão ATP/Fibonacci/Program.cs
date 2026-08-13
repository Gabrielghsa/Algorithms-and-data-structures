using System;
class Program
{
    static void Fibonacci(int n) {
        int i, a = 0, b = 1, numAtual;
        for(i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            numAtual = a;
            a = b;
            b = numAtual + b;
        } 
    }
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Informe a qtd de números na sequência. ");
            n = int.Parse(Console.ReadLine());
        } while (n < 2);
        Fibonacci(n);
        Console.ReadKey();
    }
}
