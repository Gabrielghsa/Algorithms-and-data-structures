using System;
using System.Collections;
//Código feito em sala pelo professor
class Program
{
    class Produto
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private double _Preço;

        public double Preço
        {
            get { return _Preço; }
            set
            {
                if (value > 0)
                    _Preço = value;
                else
                    Console.WriteLine("\nERRO! Preço do Produto Inválido!!");
            }
        }

        private int _Qtde;

        public int Qtde
        {
            get { return _Qtde; }
            set
            {
                if (value > 0)
                    _Qtde = value;
                else
                    Console.WriteLine("\nValor inválido para o campo...");
            }
        }

        public Produto(string xNome, double xPreço, int xQtde)
        {
            this._Nome = xNome;
            this._Preço = xPreço;
            this._Qtde = xQtde;
        }

        public double Subtotal()
        {
            return _Preço * _Qtde;
        }
    }

    class CarrinhoDeCompras
    {
        private ArrayList Cadastro;

        public CarrinhoDeCompras()
        {
            Cadastro = new ArrayList();
        }

        public void AdicionarProduto(Produto x)
        {
            Cadastro.Add(x);

            Console.WriteLine($"Produto {x.Nome} adiconado ao Carrinho...");

            Console.ReadKey();
        }

        public void ListarProdutos()
        {
            if (Cadastro.Count == 0)
                Console.WriteLine($"O Carrinho está vazio...");

            else
            {
                Console.Clear();

                Console.WriteLine("Produtos no Carrinho:");

                foreach (Produto P in Cadastro)
                {
                    Console.WriteLine($"{P.Nome} - R$ {P.Preço}");
                    Console.WriteLine($"Quantidade: {P.Qtde}");
                    Console.WriteLine($"Subtotal..: {P.Subtotal()}\n");
                }

                Console.ReadKey();
            }


        }

        public void LimparCarrinho()
        {
            Cadastro.Clear();

            Console.WriteLine($"\nCarrinho vazio...");

            Console.ReadKey();
        }

        public double CalcularTotal()
        {
            double Total = 0;

            foreach (Produto P in Cadastro)
            {
                Total += P.Subtotal();
            }

            return Total;
        }

        public void RemoverProduto(string xNome)
        {
            Produto ProdutoRemover = null;

            foreach (Produto P in Cadastro)
            {
                if (P.Nome.ToUpper() == xNome.ToUpper())
                {
                    ProdutoRemover = P;
                    break;
                }
            }

            if (ProdutoRemover != null)
            {
                Cadastro.Remove(ProdutoRemover);

                Console.WriteLine($"Produto {ProdutoRemover.Nome} retirado do Carrinho!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado!");
            }

            Console.ReadKey();
        }
    }
    static void Main(string[] args)
    {
        CarrinhoDeCompras Carrinho = new CarrinhoDeCompras();

        Produto P1 = new Produto("Teclado", 120, 2);
        Produto P2 = new Produto("Mouse", 80, 3);
        Produto P3 = new Produto("Monitor", 420, 2);

        Carrinho.AdicionarProduto(P1);
        Carrinho.AdicionarProduto(P2);
        Carrinho.AdicionarProduto(P3);

        Console.Clear();

        Carrinho.ListarProdutos();

        Carrinho.RemoverProduto("Mouse");

        Carrinho.ListarProdutos();
    }
}