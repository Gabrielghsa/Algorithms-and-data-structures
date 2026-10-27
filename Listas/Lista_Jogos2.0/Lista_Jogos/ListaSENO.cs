using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace ListaJogos
{
    class Elemento
    {
        public InfosJogo Jogo;
        public Elemento? Prox;

        public Elemento(InfosJogo jogo)
        {
            Jogo = jogo;
            Prox = null;
        }
    }

    class Lista
    {
        private Elemento? Inicio;
        private Elemento? Fim;
        private Elemento? Aux;
        private Elemento? Anterior;

        public int Tamanho = 0;

        public void InserirInicio(InfosJogo jogo)
        {
            Elemento NovoJogo = new Elemento(jogo);

            NovoJogo.Jogo = jogo;

            if (Inicio == null)
            {
                Inicio = NovoJogo;
                Fim = NovoJogo;
                NovoJogo.Prox = null;
            }
            else
            {
                NovoJogo.Prox = Inicio;
                Inicio = NovoJogo;
            }
            Tamanho++;
        }

        public void InserirFim(InfosJogo jogo)
        {
            Elemento NovoJogo = new Elemento(jogo);

            NovoJogo.Jogo = jogo;

            if (Inicio == null)
            {
                Inicio = NovoJogo;
                Fim = NovoJogo;
                NovoJogo.Prox = null;
            }
            else
            {
                Fim?.Prox = NovoJogo;
                Fim = NovoJogo;
                Fim.Prox = null;
            }
            Tamanho++;
        }

        public void RemoverJogo(int codJogo)
        {
            if (Inicio == null)
            {
                Console.WriteLine("A lista está vazia!");
                return;
            }

            Aux = Inicio;
            Anterior = null;

            int Achou = 0;
            string jogoEncontrado = "";

            while (Aux != null)
            {
                if (Aux.Jogo.Codigo == codJogo)
                {
                    jogoEncontrado = Aux.Jogo.Nome;
                    Achou++;
                    if (Aux == Inicio)
                    {
                        Inicio = Aux.Prox;

                        if (Inicio == null)
                            Fim = null;
                    }
                    else
                    {
                        Anterior?.Prox = Aux.Prox;

                        if (Aux == Fim)
                            Fim = Anterior;
                    }

                    Tamanho--;
                    Aux = Aux.Prox;
                    
                }
                else
                {
                    Anterior = Aux;
                    Aux = Aux.Prox;
                }
            }

            if (Achou == 0)
                Console.WriteLine("O jogo procurado não está na lista!");
            else if (Achou == 1)
                Console.WriteLine(
                    "O jogo {0} apareceu uma vez e foi removido!",jogoEncontrado);
            else
                Console.WriteLine(
                    "Foram removidas {0} ocorrências do jogo {1}!",Achou, jogoEncontrado);

            Console.WriteLine("Número de elementos da lista: {0}", Tamanho);
        }

        public void Pesquisar(int codigo)
        {
            Console.Clear();

            if (Inicio == null)
            {
                System.Console.WriteLine("A lista está vázia!!!");
                Console.ReadKey();
            }
            else
            {
                int Achou = 0;
                Aux = Inicio;
                while (Aux != null)
                {
                    if (Aux.Jogo.Codigo == codigo)
                    {
                        Achou++;
                        System.Console.WriteLine("Jogo {0} encontrado! ", Aux.Jogo.Nome);
                        System.Console.WriteLine("Código do jogo: {0}", Aux.Jogo.Codigo);
                        System.Console.WriteLine("Genêro: {0}", Aux.Jogo.Genero);
                        System.Console.WriteLine("Ano de lançamento: {0}", Aux.Jogo.Lancamento.Ano);
                        System.Console.WriteLine("Preço: R${0:f2}", Aux.Jogo.Preco);
                        System.Console.WriteLine("Nota {0}", Aux.Jogo.Nota);
                        break;
                    }
                   
                    Aux = Aux.Prox;
                }

                if(Achou == 0)
                    System.Console.WriteLine("\nO jogo não existe na lista!!!\n");
                
                Console.ReadKey();
            }
        }

        public void ExibirLista()
        {
            Console.Clear();

            if (Inicio == null)
            {
                System.Console.WriteLine("A lista está vázia!!!");
                Console.ReadKey();
            }
            else
            {
                Aux = Inicio;
                System.Console.WriteLine("Lista de jogos\n");
                while (Aux != null)
                {
                    System.Console.WriteLine("Jogo: {0}", Aux.Jogo.Nome);
                    System.Console.WriteLine("Código: {0}", Aux.Jogo.Codigo);
                    System.Console.WriteLine("Genêro: {0}", Aux.Jogo.Genero);
                    System.Console.WriteLine("Ano de lançamento: {0}", Aux.Jogo.Lancamento.Ano);
                    System.Console.WriteLine("Preço: R${0:f2}", Aux.Jogo.Preco);
                    System.Console.WriteLine("Nota: {0}", Aux.Jogo.Nota);
                    System.Console.WriteLine("\n");
                    Aux = Aux.Prox;
                }
                Console.ReadKey();
            }
        }

        public int QtdJogos()
        {
            return Tamanho;
        }
    }
}
