using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace FilaPilha
{
    class Elemento
    {
        public int Num;
        public Elemento Prox;

        public Elemento()
        {
            Num = 0;
            Prox = null;
        }
    }

    class Pilha
    {
        private Elemento Topo;
        private Elemento Aux;
        public int Tamanho;

        public Pilha()
        {
            Topo = null;
            Tamanho = 0;
        }

        public void Inserir(int n)
        {
            Elemento Novo = new Elemento();

            Novo.Num = n;
            Novo.Prox = Topo;
            Topo = Novo;

            Tamanho++;
        }

        public void Retirar()
        {
            int x;
            Console.Clear();

            if (Topo == null)
            {
                Console.WriteLine("A Pilha está Vázia!");
                Console.ReadKey();
            }
            else
            {
                x = Topo.Num;
                Topo = Topo.Prox;
                Tamanho--;

                Console.WriteLine($"Elemento {x} Retirado da Pilha! Tamanho da Pilha {Tamanho}.");
                Console.ReadKey();
            }
        }

        public void MostrarPilha()
        {
            Console.Clear();

            if( Topo == null)
            {
                Console.WriteLine("Pilha Vázia!!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Elementos da Pilha: ");

                Aux = Topo;

                while( Aux != null )
                {
                    Console.WriteLine($"{Aux.Num}");
                    Aux = Aux.Prox;
                }

                Console.ReadKey();
            }
        }

        public void EsvaziarPilha()
        {
            if( Topo == null )
            {
                Console.WriteLine("Pilha Vázia!!!");
                Console.ReadKey();
            }
            else
            {
                Topo = null;
                Tamanho = 0;
            }
        }
    }
}