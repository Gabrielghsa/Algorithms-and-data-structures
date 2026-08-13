using System;
class Program
{

    static double MaiorAltura(double[] altura) {
        
        double maiorAltura = altura[0];
        for (int i = 1; i < altura.Length; i++)
        {
            if (altura[i] > maiorAltura)
            {
                maiorAltura = altura[i];
            }
        }
        return maiorAltura;
    }

    static double MenorAltura(double[] altura)
    {
        double menorAltura = altura[0];
        for (int i = 1; i < altura.Length; i++)
        {
            if (altura[i] < menorAltura)
            {
                menorAltura = altura[i];
            }
        }
        return menorAltura;
    }

    static double mediaAlturaFem(double[] altura, char[] sexo) {
        int contFem = 0;
        double media, soma = 0;
        for(int i = 0; i < sexo.Length; i++)
        {
            if (sexo[i] == 'F' || sexo[i] == 'f')
            {
                soma += altura[i];
                contFem++;
            }
        }
        if(contFem == 0)
        {
            return 0;
        }
        media = (double)soma / contFem;
        return media;
    }

    static int qtdHomens(int[] idade, char[] sexo) {
        int i, contHom = 0;
        for (i = 0; i < sexo.Length; i++) {
            if (sexo[i] == 'M' || sexo[i] == 'm')
            {
                if (idade[i] >= 40 && idade[i] <= 50)
                {
                    contHom++;
                }
            }
        }
        return contHom;
    }
    static void Main(string[] args)
    {
        int[] idade = new int[5];
        double[] altura = new double[5];
        string[] nome = new string[5];
        char[] sexo = new char[5];
        for (int i = 0; i < idade.Length; i++) {
            Console.Write($"Informe o nome da {i+1}° pessoa: \n");
            nome[i] = Console.ReadLine();
            Console.Write($"Informe a idade da {i+1}° pessoa: \n");
            idade[i] = int.Parse(Console.ReadLine());
            Console.Write($"Informe a altura da {i+1}° pessoa: \n");
            altura[i] = double.Parse(Console.ReadLine());
            Console.Write($"Informe o sexo da {i+1}° pessoa: \n");
            sexo[i] = char.Parse(Console.ReadLine());
        }

        Console.Write($"A maior altura é: {MaiorAltura(altura)}\n");
        Console.Write($"A menor altura é: {MenorAltura(altura)}\n");
        Console.Write($"A média de altura das mulheres é: {mediaAlturaFem(altura, sexo)}\n");
        Console.Write($"A quantidade de homens com idade entre 40 e 50 é: {qtdHomens(idade, sexo)}");
        Console.ReadKey();
    }
}
