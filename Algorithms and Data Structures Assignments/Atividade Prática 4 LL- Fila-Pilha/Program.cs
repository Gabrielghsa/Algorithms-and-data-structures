using System;
using System.Collections;
using System.Linq;
using System.Text;
using FilaPilha;

namespace FilaPilha
{
    class Program
    {
        static void Main(string[] args)
        {

            int opFP;
            int opFila;
            do
            {
                Console.WriteLine("Escolha a estrutura: ");
                Console.WriteLine("1 - Fila");
                Console.WriteLine("2 - Pilha");
                Console.WriteLine("3 - Sair");
                opFP = int.Parse(Console.ReadLine());

                if (opFP == 1)
                {

                    Fila NovaFila = new Fila();
                    Console.Clear();
                    do
                    {
                        Console.WriteLine("======MENU DE OPÇÕES======");
                        Console.WriteLine("= 1 - Inserir");
                        Console.WriteLine("= 2 - Remover");
                        Console.WriteLine("= 3 - Mostrar FIla");
                        Console.WriteLine("= 4 - Esvaziar Fila");
                        Console.WriteLine("= 5 - Sair");
                        opFila = int.Parse(Console.ReadLine());

                        if (opFila == 1)
                        {
                            int num;

                            Console.WriteLine("Digite um número inteiro: ");
                            num = int.Parse(Console.ReadLine());

                            NovaFila.InserirNaFila(num);
                            Console.WriteLine("Valor inserido na fila!");
                            Console.ReadKey();

                        }
                        else if (opFila == 2)
                        {
                            Console.Clear();

                            NovaFila.Remover();
                            Console.WriteLine("Primeiro elemento removido!");
                            Console.ReadKey();

                        }
                        else if (opFila == 3)
                        {
                            Console.Clear();
                            NovaFila.MostrarFila();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();

                            NovaFila.EsvaziarFila();

                            Console.ReadKey();
                        }

                    } while (opFila != 5);
                }

            } while (opFP != 3);


           


            Console.ReadKey();
        }
    }
}