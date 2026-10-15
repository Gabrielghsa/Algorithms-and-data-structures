using System;
class Program
{
    static int InserirProduto(string[] prod, string x, int qtd)
    {
        if(qtd < prod.Length)
        {
            prod[qtd] = x;
            qtd++;
        }else
            Console.WriteLine("Espaço indisponível!!!");
        return qtd;
    }

    static void Main(string[] args)
    {
        string[] produtos = new string[10];
        int qtd = 0;
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Informe o {i+1} produto: ");
            string produto = Console.ReadLine();
            qtd = InserirProduto(produtos, produto, qtd);
        }

        Console.WriteLine("\n");

        for(int i = 0; i < qtd; i++)
            Console.WriteLine($"{produtos[i]}");

        int qtdDisponivel = 0;
        for(int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i] != null)
                qtdDisponivel++;
        }

        Console.WriteLine($"\nA lista possui {produtos.Length - qtdDisponivel} espaços disponíveis");

        Console.ReadKey();
    }
}