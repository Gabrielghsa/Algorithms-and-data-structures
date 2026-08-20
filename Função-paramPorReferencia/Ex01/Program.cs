using System;
class Program
{
    static void Main(string[] args)
    {
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
        Console.ReadKey();
    }

    static void dobrar(ref int valor)
    { 
        valor *= 2;
    }
    
    

}