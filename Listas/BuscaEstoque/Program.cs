using System;
class Program
{
    static int InserirProduto(string[] produtos, int qtd, string prod)
    {
        if(qtd < produtos.Length)
        {
            produtos[qtd] = prod;
            qtd++;
        }

        return qtd;
    }

    static void BuscarProduto(string[] produtos, string prod, int qtd)
    {
        int prodProcurado = -1;
        for(int i = 0; i < qtd; i++)
        {
            if (produtos[i] == prod)
            {
                prodProcurado = i;
                break;
            }
        }
        if (prodProcurado != null)
            Console.WriteLine($"Produto encontrado no índice {prodProcurado}");
        else
            Console.WriteLine("Produto não encontrado!!!");
    }

    static void Main(string[] args)
    {
        string[] produtos = new string[5];
        int qtd = 0;

        Console.WriteLine("Quantos produtos serão estocados? ");
        int estoque = int.Parse(Console.ReadLine());

        for(int i = 0; i < estoque; i++)
        {
            Console.WriteLine("Informe o nome do produto");
            string produto = Console.ReadLine();
            qtd = InserirProduto(produtos, qtd, produto);
        }

        Console.Clear();

        Console.WriteLine("Qual produto vc esta produrando? ");
        string produtoProcurado = Console.ReadLine();

        BuscarProduto(produtos, produtoProcurado, qtd);
        Console.ReadKey();
        
    }
}