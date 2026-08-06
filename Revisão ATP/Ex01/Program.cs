//Número de Kaprekar
using System;
class program
{
    static void Main()
    {
        int num = 1000, i;
        double grupo1, grupo2, quadrado;

        for(i = 1000; i <= 9999; i++)
        {
            grupo1 = i/100;
            grupo2 = i%100;
            quadrado = Math.Pow(grupo1+grupo2, 2);
            if(quadrado == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
