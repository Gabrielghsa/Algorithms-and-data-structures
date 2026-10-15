using System;
using System.Security.AccessControl;
class Program
{

    class MinhaLista
    {
        private string[] _ListaJogos = new string[50];
        private int _Quantidade;

        public int InserirFim(string novoItem)
        {
            if(_Quantidade >= _ListaJogos.Length)
                Console.WriteLine("Sem espaço suficiente! Apague um itém da lista. ");
            else
            {
                _ListaJogos[_Quantidade] = novoItem;
                _Quantidade++;
            }
            return _Quantidade;
        }

        public int InserirNaPosicao(int posicao, string novoItem)
        {
            if(_Quantidade < _ListaJogos.Length && posicao >= 0 && posicao <= _Quantidade)
            {
                for (int i = _Quantidade; i > posicao; i--)
                    _ListaJogos[i] = _ListaJogos[i - 1];

                _ListaJogos[posicao] = novoItem;
                _Quantidade++;

                Console.WriteLine("Jogo inserido na posição!");
            }
            return _Quantidade;
        }

        public int RemoverPorIndice(int posicao)
        {
            if(posicao >= 0 && posicao < _Quantidade)
            {
                for (int i = posicao; i < _Quantidade - 1; i++)
                    _ListaJogos[i] = _ListaJogos[i + 1];

                _ListaJogos[_Quantidade - 1] = null;
                _Quantidade--;
            }
            return _Quantidade;
        }

        public void PesquisarElemento(string item)
        {
            int elementoEncontrado = -1;
            for(int i = 0; i < _Quantidade; i++)
            {
                if(_ListaJogos[i] == item)
                {
                    elementoEncontrado = i;
                    break;
                }
            }
            if (elementoEncontrado != -1)
                Console.WriteLine($"Elemento encontrado na posição {elementoEncontrado}");
            else
                Console.WriteLine("Elemento não encontrado!!!");
        }

        public void ExibirLista()
        {
            Console.WriteLine("Lista de Jogos:");
            for(int i = 0;i < _Quantidade; i++)
                Console.WriteLine($"{_ListaJogos[i]}");
        }

        public void VerificarQtd()
        {
            Console.WriteLine($"A quantidade de elementos é {_Quantidade}");
        }

        public void StatusLista()
        {
            if(_Quantidade == 0)
                Console.WriteLine("A lista está vázia!");
            else if(_Quantidade < _ListaJogos.Length)
                Console.WriteLine($"A lista possui {_ListaJogos.Length - _Quantidade} posições vázias.");
            else
                Console.WriteLine("A lista está cheia!");
        }
    }

    static void Main(string[] args)
    {

        MinhaLista Jogos = new MinhaLista();
        Console.WriteLine("================================");
        Console.WriteLine("=ADICIONE UM NOVO JOGO NA LISTA=");
        Console.WriteLine("================================\n");

        do
        {
            Console.WriteLine("Digite o nome do jogo: ");
            Jogos.InserirFim(Console.ReadLine());

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Jogos.ExibirLista();
        
       
        
    }
}