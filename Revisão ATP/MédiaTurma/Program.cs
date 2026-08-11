using System;

class program
{
    static void Main()
    {
        int i;
        double soma = 0, media, diferenca;
        double[] notas = new double[5];
        for(i = 0; i < notas.Length; i++)
        {
            Console.Write($"Informe a nota do {i+1} aluno: ");
            notas[i] = double.Parse(Console.ReadLine());
            soma += notas[i];
        }
        media = (double)soma / notas.Length;
        Console.Write($"A soma das notas é: {soma}\n");
        Console.Write($"A média das notas é: {media:f2}\n");
        for(i = 0; i < notas.Length; i++)
        {
            if(notas[i] < media){
                diferenca = media - notas[i];
                Console.Write($"Aluno {i} com nota {notas[i]:f2} possui uma diferença de pontos abaixo da média de: {diferenca:f2}\n");
            }
        }
    }

}
