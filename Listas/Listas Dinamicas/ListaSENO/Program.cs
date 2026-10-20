using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaSENO
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            Lista MinhaLista = new Lista();

            do
            {
                Console.Clear();

                Console.WriteLine("LISTA SIMPLESMENTE ENCADEADA - NÃO ORDENADA");                          
                Console.WriteLine("===========================================\n");
                Console.WriteLine("Opções: \n");
                Console.WriteLine("1 - Inserir Elemento no Início da Lista");
                Console.WriteLine("2 - Inserir Elemento no Final da Lista");
                Console.WriteLine("3 - Mostrar os Elementos da Lista");
                Console.WriteLine("4 - Remover Elemento da Lista");
                Console.WriteLine("5 - Esvaziar a Lista\n");
                Console.WriteLine("6 - Extra - Verificar a Posição de um Elemento na Lista\n");
                Console.WriteLine("7 - Sair\n");

                Console.WriteLine("Digite sua opção");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    int x;
                    Console.Clear();

                    Console.WriteLine("Digite um número inteiro");
                    x = int.Parse(Console.ReadLine());
                    MinhaLista.InserirInício(x);
                    Console.WriteLine("\nElemento inserido na lista... Tamanho: {0}\n\n", MinhaLista.Tamanho);
                    Console.ReadKey();
                }
                if (op == 2)
                {
                    int x;
                    Console.Clear();

                    Console.WriteLine("Digite um número inteiro");
                    x = int.Parse(Console.ReadLine());
                    MinhaLista.InserirFinal(x);
                    Console.WriteLine("\nElemento inserido na lista... Tamanho: {0}\n\n", MinhaLista.Tamanho);
                    Console.ReadKey();
                }
                if (op == 3)
                    MinhaLista.MostraLista();

                if (op == 4)
                {
                    int x;
                    Console.Clear();

                    Console.WriteLine("Digite um número inteiro");
                    x = int.Parse(Console.ReadLine());
                    MinhaLista.RetiraElemento(x);
                }
                if (op == 5)
                {
                    Console.Clear();
                    MinhaLista.EsvaziarLista();
                    Console.WriteLine("Lista vázia!!\n\n");
                    Console.ReadKey();
                }
                if (op == 6)
                {
                    int x;
                    int pos;
                    int totElemento = 0;
                    Console.Clear();

                    Console.WriteLine("Digite um número inteiro");
                    x = int.Parse(Console.ReadLine());

                    pos = MinhaLista.VerificaPos(x, ref totElemento);

                    if(pos == 0)
                        Console.WriteLine("\nO elemento não existe na lista!\n\n");
                    else
                        Console.WriteLine("\nO elemento está na posição {0}/{1} da lista!\n\n", pos,totElemento);
                } 
                


            } while (op != 7);
        }
    }
}