using System;
class Program
{
    class Livro
    {
        private string _NomeLivro;
        private string _Autor;
        private int _QtdPaginas;
        private decimal _Valor;
        private Data _Publicacao = new Data();

        public string NomeLivro
        {
            get { return _NomeLivro; }
            set { 
                if(value != "")
                    _NomeLivro = value; 
            }
        }

        public string Autor
        {
            get { return _Autor; }
            set {
                if (value != "")
                    _Autor = value;
            }
        }

        public int QtdPaginas
        {
            get { return _QtdPaginas; }
            set
            {
                if (value != 0)
                    _QtdPaginas = value;
            }
        }

        public decimal Valor
        {
            get { return _Valor; }
            set
            {
                if(value >= 0)
                    _Valor = value;
            }
        }

        public Data Publicacao
        {
            get { return _Publicacao; }
            set { _Publicacao = value; }
        }
    }

    class Data
    {
        private string _Mes;
        private string _Ano;

        public string Mes
        {
            get { return _Mes; }
            set {  _Mes = value; }
        }

        public string Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }
    }

    class CadastroDeLivros
    {
        private Livro[] LivrosCadastrados;

        public CadastroDeLivros(int quantidade)
        {
            LivrosCadastrados = new Livro[quantidade];
        }

        public void CadastroLivro(Livro x)
        {
            for(int i = 0; i < LivrosCadastrados.Length; i++)
            {
                if (LivrosCadastrados[i] == null)
                {
                    LivrosCadastrados[i] = x;
                    break;
                }
            }
        }

        public void ListarLivros()
        {
            Console.Clear();

            foreach(Livro x in LivrosCadastrados)
            {
                if (x != null)
                {
                    if (x.QtdPaginas > 300)
                    {
                        Console.WriteLine($"Nome do Livro: {x.NomeLivro}");
                        Console.WriteLine($"Nome do Autor: {x.Autor}");
                        Console.WriteLine($"Quantidade de Páginas: {x.QtdPaginas}");
                        Console.WriteLine($"Valor do Livro: {x.Valor}");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("\n");
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Informe a quantidade de livros que serão cadastrados: ");
        int qtdLivros = int.Parse(Console.ReadLine());
        CadastroDeLivros cadastrarLivros = new CadastroDeLivros(qtdLivros);

        for (int i = 0; i < qtdLivros; i++)
        {
            Console.Clear();
            Livro livro = new Livro();

            Console.WriteLine("Nome do Livro: ");
            livro.NomeLivro = Console.ReadLine();

            Console.WriteLine("Nome do Autor: ");
            livro.Autor = Console.ReadLine();

            Console.WriteLine("Quantidade de Páginas: ");
            livro.QtdPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor do Livro R$: ");
            livro.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Mês de Publicação: ");
            livro.Publicacao.Mes = Console.ReadLine();

            Console.WriteLine("Ano de Publicação: ");
            livro.Publicacao.Ano = Console.ReadLine();

            cadastrarLivros.CadastroLivro(livro);
        }

        cadastrarLivros.ListarLivros();
        Console.ReadKey();
    }
}