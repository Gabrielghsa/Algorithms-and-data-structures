using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    //Exercício 1
    static int SomaVetor(int[] vetor, int indice, int resultado)
    {
        if (indice == vetor.Length)
            return resultado;
        return SomaVetor(vetor, indice + 1, resultado + vetor[indice]);
    }


    //Exercício 2
    static int MenorElemento(int[] vetor, int indice)
    {
        if (indice == vetor.Length - 1)
            return vetor[indice];
        int menorNum = MenorElemento(vetor, indice + 1);
        if (vetor[indice] < menorNum)
            return menorNum = vetor[indice];
        return menorNum;
    }

    //Exercício 3
    static void PalavraInvertida(string palavra, int indice)
    {
        if (indice == palavra.Length)
            return;
        PalavraInvertida(palavra, indice + 1);
        Console.Write(palavra[indice]);
    }

    //Exercício 4
    static double Potencia(int x, int y)
    {
        if (y == 0)
            return 1;
        return x * Potencia(x, y - 1);
    }

    //Exercício 5
    static int MaiorElementoPar(int[,] m, int i, int j, int maiorElemPar)
    {
        int Tam = m.GetLength(0);
        if (i == Tam)
            return maiorElemPar;
        if (j < Tam) {
            if (m[i, j] % 2 == 0)
            {
                if (m[i, j] > maiorElemPar)
                    maiorElemPar = m[i, j];
            }
            j++;
            return MaiorElementoPar(m, i, j, maiorElemPar);
        }
        else {
            i++;
            j = 0;
            return MaiorElementoPar(m, i, j, maiorElemPar);
        }
        return maiorElemPar;
    }


    //Exercício 6
    static int QtdePares(int[] vetor, int indice, int qtdePares)
    {
        if (indice == vetor.Length)
            return qtdePares;
        else
            if (vetor[indice] % 2 == 0)
                qtdePares++;
        return QtdePares(vetor, indice + 1, qtdePares);
    }


    //Exercício 7
    static void ContaDigitos(char[] n, int indice, int qtdeDigitos)
    {
        if (n.Length == indice)
        {
            Console.WriteLine($"A qtde de digitos é: {qtdeDigitos}\n");
            return;
        }
        else
        {
            ContaDigitos(n, indice + 1, qtdeDigitos + 1);
            return;
        }   
    }

    
    //Exercício 8
    static int SomaDivsores(int n, int somaDivs, int numAtual)
    {
        if (numAtual > n)
            return somaDivs;
        
        if (n % numAtual == 0)
            return SomaDivsores(n, somaDivs + numAtual, numAtual + 1);
        else
            return SomaDivsores(n, somaDivs, numAtual + 1);
    }

    static void Main(string[] args)
    {
        ////Exercício 1

        //int[] vetor = new int[20];
        //Random x = new Random();
        //for (int i = 0; i < vetor.Length; i++)
        //{
        //    vetor[i] = x.Next(0, 51);
        //}
        ////int resultado = SomaVetor(vetor, 0, 0);
        ////Console.WriteLine(resultado);


        ////Exercício 2
        //int menorElementoDoVetor = MenorElemento(vetor, 0);
        //foreach (int n in vetor)
        //{
        //    Console.Write($"{n}  ");
        //}
        //Console.WriteLine("\n");
        //Console.WriteLine(menorElementoDoVetor);
        //-----------------------------------------------

        //string palavra = "Macrebs";
        //Console.WriteLine(palavra);
        //PalavraInvertida(palavra, 0);
        //--------------------------------------


        //Exercício 4
        //Console.WriteLine("Informe o valor de z: ");
        //int z = int.Parse(Console.ReadLine());
        //Console.WriteLine("Informe o valor de y: ");
        //int y = int.Parse(Console.ReadLine());
        //double resultado = Potencia(z, y);
        //Console.WriteLine($"O resultado é {resultado}");
        //Console.ReadKey();
        //---------------------------------------------



        //Exercício 5
        //    int[,] matriz = new int[5, 5];

        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            matriz[i, j] = x.Next(0, 101);
        //            Console.Write($"{matriz[i, j],6}");
        //        }
        //        Console.WriteLine("\n");
        //    }

        //    int maiorPar = MaiorElementoPar(matriz, 0, 0, int.MinValue);
        //    if (maiorPar < 0)
        //        Console.Write("A matriz não possui valores pares");
        //    else
        //        Console.WriteLine($"Maior elemento par da matriz: {maiorPar}");
        //------------------------------------------------------------------------------


        //Exercício 6
        //int[] nums = new int[10];
        //for (int i = 0; i < nums.Length; i++) {
        //    nums[i] = x.Next(0, 51);
        //    Console.Write($"{nums[i],5}");
        //}
        //int qtdePares = QtdePares(nums, 0, 0);
        //Console.Write($"\nA qtde de números pares no vetor é: {qtdePares}");

        //Exercício 7
        //Console.Write("Informe o valor de n: ");
        //int n = int.Parse(Console.ReadLine());
        //char[] nString = n.ToString().ToCharArray();
        //foreach (char c in nString)
        //    Console.Write($"{c,6}");
        //Console.WriteLine("\n\n");
        //ContaDigitos(nString, 0, 0);

        //Exercício 8
        Console.Write("Informe o valor de X: ");
        int x = int.Parse(Console.ReadLine());

        int somaDivs = SomaDivsores(x, 0, 1);
        Console.Write($"A soma dos divisores de {x} é: {somaDivs}");

        Console.ReadKey();











        //int op;
        //do
        //{
        //    Console.WriteLine("Escolha uma das opções...");
        //    Console.WriteLine("Op 1: Soma Vetor");
        //    Console.WriteLine("Op 2: Menor número do vetor");
        //    Console.WriteLine("Op 3: Inverter palavra");
        //    Console.WriteLine("Op 4: Potência x^y");
        //    Console.WriteLine("Op 5: Maior elemento par de uma matriz");
        //    Console.WriteLine("Op 6: Qtde pares");
        //    Console.WriteLine("Op 7: Qtde de digitos de um número");
        //    Console.WriteLine("Op 8: Qtde divisores");
        //    Console.WriteLine("Op 9: Soma da diagonal princípal de uma matriz");
        //    Console.Write("Op 0: Sair");

        //} while (op != 0);
    }
}