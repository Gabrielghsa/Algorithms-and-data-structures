using System;
using System.Collections;
class Program
{
    class Categoria
    {
        public string CodCateg { get; set; }
        public string NomeCateg { get; set; }
    }

    class Produto
    {
        public string CodProd {  get; set; }
        public string NomeProd { get; set; }
        public string Categoria { get; set; }
        public int QtdeEstoque { get; set; }
        public double PrecoUnit {  get; set; }
    }

    class Dados
    {
        private ArrayList CadastroCategorias;
        private ArrayList CadastroProdutos;

        public Dados()
        {
            CadastroCategorias = new ArrayList();
            CadastroProdutos = new ArrayList();
        }
        public void CadastraCategoria(Categoria x)
        {
            CadastroCategorias.Add(x);
        }

        public void CadastraProduto(Produto x)
        {
            CadastroProdutos.Add(x);
        }

        public Categoria PesquisaCategoria(string Codigo)
        {
            Categoria Cat = null;
            foreach(Categoria xCat in CadastroCategorias) {
                if (xCat.CodCateg == Codigo)
                    return xCat;
            }
            return Cat;
        }

        public void ListaProdutos()
        {
            Console.Clear();

            foreach(Produto P in CadastroProdutos)
            {
                Console.WriteLine($"{P.NomeProd} ({P.CodProd})");
                Console.WriteLine($"Categoria: {PesquisaCategoria(P.Categoria).NomeCateg}");
                Console.WriteLine($"Preço...: R$ {P.PrecoUnit:F2}");
                Console.WriteLine($"Estoque..: {P.QtdeEstoque}\n");
            }
            Console.ReadKey();
        }

    }
    static void Main(string[] args)
    {
        Dados Cadastro = new Dados();
        //Cadastrando Categorias
        do
        {
            Console.Clear();

            Categoria x = new Categoria();

            Console.WriteLine("Cadastro de Categorias: \n");

            Console.Write("Código da Categoria.....: ");
            x.CodCateg = Console.ReadLine();

            Console.Write("Nome da Categoria.......: ");
            x.NomeCateg = Console.ReadLine();

            Cadastro.CadastraCategoria(x);

            Console.Write("\nCadastrar outra Categoria? (ESC cancela...)");

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        //Cadastrando Produtos
        do
        {
            Console.Clear();

            Produto x = new Produto();

            Console.WriteLine("Cadastro de Produtos em Estoque: \n");

            Console.Write("Código do Produto.....: ");
            x.CodProd = Console.ReadLine();

            Console.Write("Nome do Produto.......: ");
            x.NomeProd = Console.ReadLine();

            Console.Write("Categoria.............: ");
            x.Categoria = Console.ReadLine();

            Console.Write($"    ==> {Cadastro.PesquisaCategoria(x.Categoria).NomeCateg}");

            Console.Write("Qtde em Estoque.......: ");
            x.QtdeEstoque = int.Parse(Console.ReadLine());

            Console.Write($"Preço Unitário (R$)..: ");
            x.PrecoUnit = double.Parse(Console.ReadLine());

            Cadastro.CadastraProduto(x);
            Console.Write("\nCadastrar outro Produto? (ESC cancela...)");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Cadastro.ListaProdutos();
    }
}