using System;
using System.Collections;
class Program
{
    class Produto
    {
        private string _Nome;
        private double _Preco;
        private int _Quantidade;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public double Preco
        {
            get { return _Preco; }
            set
            {
                if (value >= 0)
                    _Preco = value;
            }
        }
        
        public int Quantidade
        {
            get { return _Quantidade; }
            set { 
                if(value >= 0)    
                    _Quantidade = value; 
            }
        }

        public void Vender(int qtd)
        {
            if(qtd > 0 && Quantidade >= qtd)
            {
                Quantidade -= qtd;
                Console.WriteLine($"A quantidade {qtd} vendida. Quantidade atual em estoque {Quantidade}\n");
            }else
                Console.WriteLine("Não foi possível realizar a venda.\n");
        }

        public void Repor(int qtd)
        {
            if (qtd > 0)
            {
                Quantidade += qtd;
                Console.WriteLine($"Estoque reposto. Nova quantidade em estoque {Quantidade}\n");
            }else
                Console.WriteLine("Quantidade inválida para reposição.\n");
        }

        public void CalcFaturamento(int qtdVendida)
        {
            double faturamento = 0;
            if(qtdVendida > 0)
            {
                faturamento = qtdVendida * Preco;
            }
            Console.WriteLine($"Faturamento de {faturamento:f2}\n");
        }
    }

    class Dados
    {
        private ArrayList ProdutoCadastrado;

        public Dados()
        {
            ProdutoCadastrado = new ArrayList();
        }

        public void Cadastro(Produto x)
        {
            ProdutoCadastrado.Add(x);
        }

        public void ListarProdutos()
        {
            foreach (Produto x in ProdutoCadastrado)
            {
                Console.WriteLine($"Nome do Produto: {x.Nome}\n\n");
                Console.WriteLine($"Preço do Produto: {x.Preco:f2}\n\n");
                Console.WriteLine($"QTD do Produto: {x.Quantidade}\n\n");
            }
        }
    }

    static void Main(string[] args)
    {
        Dados dados = new Dados();

        for (int i = 0; i < 3; i++)
        {

            Produto xprod = new Produto();
            Console.Write("Informe Nome do Produto: ");
            xprod.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Preço do produto: ");
            xprod.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine($"Informe a quantidade de {xprod.Nome} tem no estoque atualmente: ");
            xprod.Quantidade = int.Parse(Console.ReadLine());
            dados.Cadastro(xprod);
        }

        dados.ListarProdutos();
        //xprod.Vender(5);
        //xprod.Repor(10);
        //xprod.CalcFaturamento(5);
        Console.ReadKey();
    }
}