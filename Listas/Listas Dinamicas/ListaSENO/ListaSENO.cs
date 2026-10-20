using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaSENO
{

    public class Elemento
    {
        public int Num;
        public Elemento Prox;

        public Elemento()
        {
            Num = 0;
            Prox = null;
        }
    }

    public class Lista
    {
        private Elemento Início;            // Primeiro elemento da lista
        private Elemento Fim;               // Último elemento da lista
        private Elemento Aux;               // Objeto auxiliar
        private Elemento Anterior;          // Objeto auxiliar

        public int Tamanho;                 // Número de Elementos da Lista

        public Lista()                      // Construtor da Classe
        {
            Início = null;
            Fim = null;
            Tamanho = 0;
        }

        // Função para inserir um elemento no início da lista
        public void InserirInício(int Valor)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo Elemento para a Lista

            Novo.Num = Valor;                   // Insere o valor do elemento na lista

            if (Início == null)                 // A lista está vazia? Primeiro elemento...
            {
                Início = Novo;                  // O elemento inserido é o primeiro e o último. Guarda o endereço dele.
                Fim = Novo;

                Novo.Prox = null;               // O ponteiro para o próximo elemento passa a ser nulo
            }
            else                                // A lista já possui elementos?
            {
                Novo.Prox = Início;             // O elemento Novo aponta para o elemento que já havia sido inserido anteriormente
                Início = Novo;                  // e o Início passa a ter o endereço do elemento Novo
            }

            Tamanho++;                          // O elemento entrou na lista
        }

        // Função para inserir um elemento no final da lista
        public void InserirFinal(int Valor)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo Elemento para a Lista

            Novo.Num = Valor;                   // Insere o valor do elemento na lista

            if (Início == null)                 // A lista está vazia? Primeiro elemento...
            {
                Início = Novo;                  // O elemento inserido é o primeiro e o último. Guarda o endereço dele.
                Fim = Novo;

                Novo.Prox = null;               // O ponteiro para o próximo elemento passa a ser nulo
            }
            else                                // A lista já possui elementos?
            {
                Fim.Prox = Novo;                // O elemento que era o último da lista aponta para o elemento inserido
                Fim = Novo;                     // Atualiza o último: o elemento final passa a ser o novo elemento inserido
                Fim.Prox = null;                // e o endereço dele aponta para ninguém, já que ele é o último
            }

            Tamanho++;                          // O elemento entrou na lista
        }

        //Função para mostrar todos os elementos da lista
        public void MostraLista()
        {
            Console.Clear();            // Limpa a tela

            if (Início == null)         // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else                        // Se a lista tem pelo menos um elemento
            {
                Console.WriteLine("Elementos da Lista: {0}\n", Tamanho);

                Aux = Início;           // Pega o primeiro elemento

                while (Aux != null)     // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    Console.WriteLine("{0,5}", Aux.Num);        // Mostra o elemento,
                    Aux = Aux.Prox;                             // aponta para o próximo elemento
                }                                               // e volta

                Console.ReadKey();
            }
        }

        //Função para retirar um elemento da lista
        public void RetiraElemento(int Valor)
        {
            Console.Clear();                        // Limpa a tela

            if (Início == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A lista não está vazia
            {
                Aux = Início;                       // Pega o endereço do primeiro elemento
                Anterior = null;                    // Objeto auxiliar

                int Achou = 0;                      // Variável para contar quantas vezes o elemento é encontrado na lista

                while (Aux != null)                 // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    if (Aux.Num == Valor)           // O número digitado foi encontrado na lista
                    {
                        Achou++;                    // Conta ocorrência

                        if (Aux == Início)                  // O número a ser removido é o primeiro da lista?
                        {
                            Início = Aux.Prox;              // O primeiro elemento agora foi removido e ganha o endereço do segundo
                            Aux = Início;                   // Armazena o endereço dele para o próximo uso

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                        else if (Aux == Fim)                // O número a ser removido é o último da lista?
                        {
                            Anterior.Prox = null;           // O Anterior aponta para nulo, já que
                            Fim = Anterior;                 // ele agora passou a ser o último elemento
                            Aux = null;                     // O Aux agora aponta para nada

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                        else                                // O número a ser removido está no meio da lista?
                        {
                            Anterior.Prox = Aux.Prox;       // O elemento anterior aponta para o próximo elemento depois daquele
                            Aux = Aux.Prox;                 // que foi retirado e o endereço dele é armazenado para uso futuro

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                    }
                    else                                    // reposiciona para o próximo elemento da lista
                    {
                        Anterior = Aux;                     // O anterior é o próximo
                        Aux = Aux.Prox;
                    }
                }                                           // e volta para nova pesquisa

                if (Achou == 0)                             // Não encontrou o número na lista
                {
                    Console.WriteLine("O valor {0} não foi encontrado na lista!!! \n", Valor);
                }
                else if (Achou == 1)                        // Achou uma ocorrência
                {
                    Console.WriteLine("O valor {0} foi encontrado na lista e removido!!! \n", Valor);
                }
                else                                        // Achou mais de uma ocorrência
                {
                    Console.WriteLine("O valor {0} foi encontrado {1} vezes na lista e removido!!! \n", Valor, Achou);
                }

                Console.WriteLine("Número de Elementos da Lista: {0}\n\n", Tamanho);
                Console.ReadKey();
            }
        }

        //Função para esvaziar toda a lista
        public void EsvaziarLista()
        {
            if (Início == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A lista não está vazia
            {
                Início = null;                      // O Início da Lista não aponta para ninguém...
                Tamanho = 0;
            }
        }

        //Função para Verificar se um Elemento existe na lista
        public int VerificaPos(int Elemento, ref int NrElementos)
        {
            int PosElemento = 0;        // Posição do Elemento na Lista

            Aux = Início;           // Pega o primeiro elemento

            while (Aux != null)     // Enquanto a lista tiver elementos que apontam para outro elemento da lista
            {
                NrElementos++;

                if (Elemento == Aux.Num)
                {
                    PosElemento = NrElementos;
                }
                Aux = Aux.Prox;                             // aponta para o próximo elemento
            }

            return PosElemento;

        }
    }
}