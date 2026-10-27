using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace FilaPilha
{
    class Fila
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;
        private int Tamanho;

        public Fila()
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }

        public void InserirNaFila(int n)
        {
            Elemento Novo = new Elemento();

            Novo.Num = n;
            Novo.Prox = null;

            if (Inicio == null)
            {
                Inicio = Novo;
                Fim = Novo;
            }
            else
            {
                Fim.Prox = Novo;
                Fim = Novo;
            }

            Tamanho++;
        }

        public void Remover()
        {
            int n;
            Console.Clear();

            if(Inicio == null)
            {
                Console.WriteLine("A fila está vázia!");
                Console.ReadKey();
            }
            else
            {
                n = Inicio.Num;
                Inicio = Inicio.Prox;
                Tamanho--;
                Console.WriteLine($"Elemento {n} Removido. Tamanho da Fila {Tamanho}");
                Console.ReadKey();
            }
        }

        public void MostrarFila()
        {
            
            Console.Clear();

            if( Inicio == null )
            {
                Console.WriteLine("Fila Vázia!!!");
                Console.ReadKey();
            }
            else
            {
                Aux = Inicio;

                while( Aux != null )
                {
                    Console.WriteLine($"{Aux.Num}");
                    Aux = Aux.Prox;
                }
                Console.ReadKey();
            }

        }

        public void EsvaziarFila()
        {
            if(Inicio == null)
            {
                Console.WriteLine("A Fila Está Vázia!");
                Console.ReadKey();
            }
            else
            {
                Inicio = null;
                Tamanho = 0;
            }
        }
    }
}