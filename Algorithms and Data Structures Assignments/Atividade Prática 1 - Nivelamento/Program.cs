using System;
class Program
{
    //Função para calcular o total de vendas de cada vendedor na semana
    static double[] CalcTotalVendedor(double[,] vendas)
    {
        double[] vendasTotais = new double[vendas.GetLength(0)];
        double soma;

        for (int i = 0; i < vendas.GetLength(0); i++)
        {
            soma = 0;
            for (int j = 0; j < vendas.GetLength(1); j++)
            {
                soma += vendas[i, j];
            }
            vendasTotais[i] = soma;
        }
        return vendasTotais;
    }

    //Função para calcular a soma total de vendas diárias
    static double[] CalcTotalDiario(double[,] vendas)
    {
        double[] vendasDiarias = new double[vendas.GetLength(1)];
        double soma;
        for (int i = 0; i < vendas.GetLength(1); i++)
        {
            soma = 0;
            for (int j = 0; j < vendas.GetLength(0); j++)
            {
                soma += vendas[j, i];
            }
            vendasDiarias[i] = soma;
        }
        return vendasDiarias;
    }

    //Função para descobrir a média de todas as vendas
    static double CalcMediaVendas(double[,] vendas)
    {
        double somaTotal = 0;
        double media;
        for (int i = 0; i < vendas.GetLength(0); i++)
            for (int j = 0; j < vendas.GetLength(1); j++)
            {
                somaTotal += vendas[i, j];
            }
        media = somaTotal / (vendas.GetLength(0) * vendas.GetLength(1));
        return media;
    }

    //Procedimento para mostrar as vendas totais de cada vendedor
    static void MostraVendasVendedor(double[] vetorVendas)
    {
        int numVendedor = 0;
        foreach (double v in vetorVendas)
        {
            numVendedor++;
            Console.Write($"Vendedor {numVendedor}: {v:C}\n");
        }
        Console.WriteLine("\n");
    }

    //Procedimento para mostrar as vendas totais diária
    static void MostraVendasDiarias(double[] vendasDiarias, string[] dias)
    {
        for(int i = 0;i < vendasDiarias.Length; i++)
            Console.Write($"{dias[i]}: {vendasDiarias[i]:C}\n");
        Console.WriteLine();
    }

    //Procedimento para identicar o vendedor com maior volume de vendas
    static void MaiorVendaVendedor(double[] vendasVendedor)
    {
        int vendedor = 0;
        double maiorVenda = vendasVendedor[0]; 
        for (int i = 0; i < vendasVendedor.Length; i++)
            if (vendasVendedor[i] > maiorVenda)
            {
                maiorVenda = vendasVendedor[i];
                vendedor = i;
            }
        Console.WriteLine($"Vendedor com as maiores vendas: Vendedor {vendedor+1}\nCom total de: {maiorVenda:C}\n");
    }

    //Procedimento para identificar qual dia da semana teve maior volume de vendas
    static void ExibindoDiaMaiorVenda(double[] diaMaiorVenda, string[] dias)
    {
        string diaMaior = dias[0];
        double maiorVenda = diaMaiorVenda[0];
        for (int i = 1; i < diaMaiorVenda.Length; i++)
            if (diaMaiorVenda[i] > maiorVenda)
            {
                maiorVenda = diaMaiorVenda[i];
                diaMaior = dias[i];
            }
        Console.WriteLine($"Dia com maior volume de vendas: {diaMaior}\nCom um total de {maiorVenda:C}\n");
    }

    //Procedimento para mostrar as vendas acima da média
    static void VendasAciMedia(double[,] vendas, double media)
    {
        int qtdVendasAciMedia = 0;
        for (int i = 0; i < vendas.GetLength(0); i++)
            for (int j = 0; j < vendas.GetLength(1); j++)
                if (vendas[i, j] > media) qtdVendasAciMedia++;

        Console.WriteLine($"A média das vendas é: {media:C}\nE a quantidade de vendas acima da média é: {qtdVendasAciMedia}\n");
    }

    static void Main(string[] args)
    {
        double[,] vendas = new double[4, 5];
        string[] diasSemana = { "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira" };

        Console.Write("Informe os valores das vendas de cada dia da semana:\n");
        for(int i = 0; i < vendas.GetLength(0); i++)
        {
            for (int j = 0; j < vendas.GetLength(1); j++)
            {
                bool valido = false;
                while (!valido)
                {
                    try
                    {
                        Console.Write($"Vendedor {i + 1} no dia {j + 1}: ");
                        vendas[i, j] = double.Parse(Console.ReadLine());
                        valido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro, apenas valores numéricos são aceitos.");
                    }
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n============RELATÓRIO=============\n");
        Console.Write("TOTAL VENDIDO POR CADA VENDEDOR\n");
        Console.Write("----------------------------------\n");
        double[] totalVendidoVendedor = CalcTotalVendedor(vendas);
        MostraVendasVendedor(totalVendidoVendedor);

        Console.Write("TOTAL VENDIDO EM CADA DIA\n");
        Console.Write("----------------------------------\n");
        double[] totaldiario = CalcTotalDiario(vendas);
        MostraVendasDiarias(totaldiario, diasSemana);

        Console.Write("RESUMO\n");
        Console.Write("-----------------------------------\n");
        MaiorVendaVendedor(totalVendidoVendedor);

        ExibindoDiaMaiorVenda(totaldiario, diasSemana);

        double mediaDasVendas = CalcMediaVendas(vendas);
        VendasAciMedia(vendas, mediaDasVendas);

        Console.WriteLine("=====================================");
        Console.ReadKey();
    }
}