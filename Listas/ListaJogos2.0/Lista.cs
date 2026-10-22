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
        public Elemento Prox;

        public Elemento()
        {
            Jogo = null;
            Prox = null;
        }
    }

    class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;
        private Elemento Aux;
        private Elemento Anterior;

        public int Tamanho;

        public Lista()
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }

        public void InserirInicio(InfosJogo jogo)
        {
            Elemento NovoJogo = new Elemento();

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
            Elemento NovoJogo = new Elemento();

            NovoJogo.Jogo = jogo;

            if (Inicio == null)
            {
                Inicio = NovoJogo;
                Fim = NovoJogo;
                NovoJogo.Prox = null;
            }
            else
            {
                Fim.Prox = NovoJogo;
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

                    // Caso 1: remover o primeiro nó
                    if (Aux == Inicio)
                    {
                        Inicio = Aux.Prox;

                        // Se era o único nó, a lista fica vazia
                        if (Inicio == null)
                            Fim = null;
                    }
                    else
                    {
                        // Caso 2: remover um nó do meio ou do fim
                        Anterior.Prox = Aux.Prox;

                        // Se era o último nó, atualizar Fim
                        if (Aux == Fim)
                            Fim = Anterior;
                    }

                    Tamanho--;

                    // Avança sem alterar Anterior
                    // O próximo nó também precisa ser verificado
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
                    "O jogo {0} apareceu uma vez e foi removido!",
                    jogoEncontrado);
            else
                Console.WriteLine(
                    "Foram removidas {0} ocorrências do jogo {1}!",
                    Achou, jogoEncontrado);

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
                        System.Console.WriteLine("Jogo {0} encontrado!", Aux.Jogo.Nome);
                        System.Console.WriteLine("Código do jogo {0}!", Aux.Jogo.Codigo);
                        System.Console.WriteLine("Genêro {0}!", Aux.Jogo.Genero);
                        System.Console.WriteLine("Ano de lançamento {0}!", Aux.Jogo.Lancamento.Ano);
                        System.Console.WriteLine("Preço {0:f2}!", Aux.Jogo.Preco);
                        System.Console.WriteLine("Classificação indicativa {0}!", Aux.Jogo.ClassificacaoIndicativa);
                    }
                    Aux = Aux.Prox;
                }

                if (Achou == 0)
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
                System.Console.WriteLine("Lista de jogos");
                while (Aux != null)
                {
                    System.Console.WriteLine("Jogo {0} encontrado!", Aux.Jogo.Nome);
                    System.Console.WriteLine("Código do jogo {0}!", Aux.Jogo.Codigo);
                    System.Console.WriteLine("Genêro {0}!", Aux.Jogo.Genero);
                    System.Console.WriteLine("Ano de lançamento {0}!", Aux.Jogo.Lancamento.Ano);
                    System.Console.WriteLine("Preço {0:f2}!", Aux.Jogo.Preco);
                    System.Console.WriteLine("Classificação indicativa {0}!", Aux.Jogo.ClassificacaoIndicativa);
                    System.Console.WriteLine("\n\n");
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