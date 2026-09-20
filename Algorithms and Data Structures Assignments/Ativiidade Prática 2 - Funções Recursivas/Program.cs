using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static int[] GerarVetor(int[] vetor, int indice, Random random)
    {
        if (indice == vetor.Length)
            return vetor;
        vetor[indice] = random.Next(0, 51);
        return GerarVetor(vetor, indice + 1, random);
    }

    static int SomaVetor(int[] vetor, int indice, int resultado)
    {
        if (indice == vetor.Length)
            return resultado;
        return SomaVetor(vetor, indice + 1, resultado + vetor[indice]);
    }

    static int MenorElemento(int[] vetor, int indice)
    {
        if (indice == vetor.Length - 1)
            return vetor[indice];
        int menorNum = MenorElemento(vetor, indice + 1);
        if (vetor[indice] < menorNum)
            return vetor[indice];
        return menorNum;
    }

    static string PalavraInvertida(string palavra)
    {
        if (palavra.Length <= 1)
            return palavra;
        return palavra[palavra.Length - 1] + PalavraInvertida(palavra.Substring(0, palavra.Length - 1));
    }

    static double Potencia(int x, int y)
    {
        if (y == 0)
            return 1;
        return x * Potencia(x, y - 1);
    }

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
    }

    static int QtdePares(int[] vetor, int indice, int qtdePares)
    {
        if (indice == vetor.Length)
            return qtdePares;
        else
            if (vetor[indice] % 2 == 0)
                qtdePares++;
        return QtdePares(vetor, indice + 1, qtdePares);
    }

    static int ContaDigitos(int n)
    {
        if (n < 0)
            n = -n;

        if (n < 10)
            return 1;
        return 1 + ContaDigitos(n / 10);
    }

    static int SomaDivsores(int n, int somaDivs, int numAtual)
    {
        if (numAtual > n)
            return somaDivs;

        if (n % numAtual == 0)
            return SomaDivsores(n, somaDivs + numAtual, numAtual + 1);
        else
            return SomaDivsores(n, somaDivs, numAtual + 1);
    }

    static int[,] GerarMatriz(int[,] matriz, int i, int j, int Tamanho, Random random)
    {
        if (i == Tamanho)
            return matriz;

        if(j < Tamanho)
        {
            matriz[i, j] = random.Next(1, 51);
            j++;
            return GerarMatriz(matriz, i, j, Tamanho, random);
        }
        else
        {
            i++;
            j = 0;
            return GerarMatriz(matriz, i, j, Tamanho, random);
        }
    }

    static void MostrarMatriz(int[,] matriz, int i, int j, int Tamanho)
    {
        
        if (i == Tamanho)
            return;
        if(i < Tamanho && j < Tamanho)
        {
            Console.Write($"{matriz[i, j],5}");
            j++;
            MostrarMatriz(matriz, i, j, Tamanho);
        }
        else if (i < Tamanho && j == Tamanho)
        {
            i++;
            j = 0;
            Console.WriteLine();
            MostrarMatriz(matriz, i, j, Tamanho);
        }
    }

    static void MostrarDiagonal(int[,] matriz, int i, int j, int Tamanho){
        if (i == Tamanho)
            return;
        Console.Write($"{matriz[i, j]}  ");
        MostrarDiagonal(matriz, i + 1, j + 1, Tamanho);
    }

    static int SomarDiagonal(int[,] matriz, int i, int soma, int Tamanho)
    {
        if (i == Tamanho)
            return soma;

        soma += matriz[i, i];
        return SomarDiagonal(matriz, i+1, soma, Tamanho);
    }

    static void Main(string[] args)
    {
        int op;
        Random random = new Random();
        do
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("=              MENU DE OPÇÕES                   =");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine("Op 1: Somar elementos do vetor: ");
            Console.WriteLine("Op 2: Menor elemento do vetor: ");
            Console.WriteLine("Op 3: Inverter palavra: ");
            Console.WriteLine("Op 4: Potência: ");
            Console.WriteLine("Op 5: Maior elemento par de uma matriz: ");
            Console.WriteLine("Op 6: Quantidade de pares em um vetor: ");
            Console.WriteLine("Op 7: Quantidade de digitos de um número: ");
            Console.WriteLine("Op 8: Quantidade divisores: ");
            Console.WriteLine("Op 9: Soma da diagonal princípal de uma matriz: ");
            Console.WriteLine("=================================================");
            Console.Write("\nESC para Sair\n");
            Console.Write("\nDigite uma opção...: ");
 
            op = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (op)
            {
                case 1:
                    int[] vet = new int[20];
                    vet = GerarVetor(vet, 0, random);

                    foreach (int elem in vet)
                    {
                        Console.Write($"{elem}  ");
                    }

                    int resultado = SomaVetor(vet, 0, 0);
                    Console.WriteLine($"\n\n==> A soma dos elementos do vetor é: {resultado}");                   
                    break;

                case 2:
                    int[] vetor = new int[20];
                    vetor = GerarVetor(vetor, 0, random);
                    int menorElementoDoVetor = MenorElemento(vetor, 0);
                    foreach (int numero in vetor)
                    {
                        Console.Write($"{numero}    ");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"\n\n==> O menor elemento do vetor é: {menorElementoDoVetor}");                
                    break;

                case 3:
                    Console.Write("Digite qual palavra será invertida...: ");
                    string palavra = Console.ReadLine();
                    string palavraInvertida = PalavraInvertida(palavra);
                    Console.Write($"A palavra {palavra} escrita invertida fica: {palavraInvertida}"); 
                    break;

                case 4:
                    Console.Write("Informe o valor da base: ");
                    int bas = int.Parse(Console.ReadLine());
                    Console.Write("Informe o valor da potência: ");
                    int pot = int.Parse(Console.ReadLine());
                    double resultadoPot = Potencia(bas, pot);
                    Console.WriteLine($"\n==> {bas}^{pot} = {resultadoPot}");
                break;

                case 5:
                    
                    int[,] matriz = new int[5, 5];
                    Console.Write("\nMatriz\n\n");


                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            matriz[i, j] = random.Next(0, 101);
                            Console.Write($"{matriz[i, j],6}");
                        }
                        Console.WriteLine("\n");
                    }
                    int maiorPar = MaiorElementoPar(matriz, 0, 0, int.MinValue);
                    if (maiorPar < 0)
                        Console.Write("A matriz não possui valores pares");
                    else
                        Console.WriteLine($"Maior elemento par da matriz: {maiorPar}");
                    break;

                 case 6:
                    
                    int[] nums = new int[10];
                    for (int i = 0; i < nums.Length; i++) {
                        nums[i] = random.Next(0, 51);
                        Console.Write($"{nums[i]}   ");
                    }
                    int qtdePares = QtdePares(nums, 0, 0);
                    Console.Write($"\n\n==> A qtde de números pares no vetor é: {qtdePares}");
                    break; 

                case 7:
                    Console.Write("Informe um número: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    int qtdeDigitos = ContaDigitos(n);
                    Console.Write($"O número {n} possui {qtdeDigitos} digitos.");
                    break;
                case 8:
                    Console.Write("Informe o número: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Divisores: ");
                    for(int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                            Console.Write($"{i}    ");
                    }
                    int somaDivs = SomaDivsores(num, 0, 1);
                    Console.WriteLine();
                    Console.Write($"\nA soma dos divisores de {num} é: {somaDivs}");
                    break;
                case 9:
                    Console.Write("Qual o tamanho da matriz quadrada: ");
                    int tam = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    int[,] matrizGerada = new int[tam, tam];

                    matrizGerada = GerarMatriz(matrizGerada, 0, 0, tam, random);
                    Console.WriteLine("Matriz: \n");
                    MostrarMatriz(matrizGerada, 0, 0, tam);
                    Console.Write("\nDiagonal principal da matriz: ");
                    MostrarDiagonal(matrizGerada, 0, 0, tam);

                    int soma = 0;
                    soma = SomarDiagonal(matrizGerada, 0, soma, tam);

                    Console.Write($"\n\n==> A soma da diagonal é {soma}");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente!!!");
                    break;
            }
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}