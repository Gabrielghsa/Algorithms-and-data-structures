using System;
class Porgram
{
    //Inserção no fim
    static int InserirNoFim(string[] clientes, int qtd, string novaP)
    {
        if (qtd < clientes.Length)
        {
            clientes[qtd] = novaP;
            qtd++;
        } else
            Console.WriteLine("Não há espaço disponível...");

        return qtd;
        
    }

    //Inserção em uma posição específica
    static int InserirNaPosicao(string[] clientes, int qtd, string x, int posicao)
    {
        if (qtd < clientes.Length && posicao >= 0 && posicao <= qtd) {
            for (int i = qtd; i > posicao; i--)
                clientes[i] = clientes[i - 1];

            clientes[posicao] = x;
            qtd++;
        } 
        return qtd;
    }

    //Removendo elemento
    static int RemoverElemento(string[] clientes, int posicao, int qtd)
    {
        if (posicao >= 0 && posicao < qtd) {
            for (int i = posicao; i < qtd - 1; i++)
                clientes[i] = clientes[i + 1];
            clientes[qtd - 1] = null;
            qtd--;
        }
        
        return qtd;
    }

    //Pesquisando elemento
    static void PesquisarElemento(string[] clientes, string x, int qtd)
    {
        int posicaoEncontrada = -1;
        for (int i = 0; i < qtd; i++)
        {
            if (clientes[i] == x)
            {
                posicaoEncontrada = i;
                break;
            }
        }

        if (posicaoEncontrada != -1)
            Console.WriteLine($"Cliente encontrado no índice {posicaoEncontrada}");
        else
            Console.WriteLine("Cliente não encontrado!!!");
    }
    static void Main(string[] args)
    {
        string[] clientes = new string[10];
        clientes[0] = "Carlos";
        clientes[1] = "Mariana";
        clientes[2] = "João";

        int quantidade = 3;
        string novaPessoa = "Ana";
        string novoCliente = "Macrebs";
        string nomeProcurado = "Ana";
        
        int novaQtd = InserirNoFim(clientes, quantidade, novaPessoa);
        novaQtd = InserirNaPosicao(clientes, novaQtd, novoCliente, 0);
        //novaQtd = RemoverElemento(clientes, 0, novaQtd);
        PesquisarElemento(clientes, nomeProcurado, novaQtd);


        for (int i = 0; i < novaQtd; i++)
            Console.WriteLine($"{clientes[i]}");
        Console.ReadKey();
    }
}