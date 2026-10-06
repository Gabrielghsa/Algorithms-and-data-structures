using System;
using System.Collections;
class Program
{

    class Filme
    {
        private string _Nome;
        private string _Diretor;
        private string _Duracao;
        private int _Nota;
        private Data _Lancamento = new Data();

        public string Nome
        {
            get { return _Nome;  }
            set { _Nome = value; }
        }

        public string Diretor
        {
            get { return _Diretor; }
            set { _Diretor = value; }
        }

        public string Duracao
        {
            get { return _Duracao; }
            set { _Duracao = value; }
        }

        public int Nota
        {
            get { return _Nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    _Nota = value;
            }
        }

        public Data Lancamento
        {
            get { return _Lancamento; }
            set { _Lancamento = value; }
        }
    }

    class Data
    {
        private string _Mes;
        private string _Ano;

        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }

        public string Ano
        {
            get { return _Ano; }
            set { _Ano = value; }
        }
    }

    class CadastroFilmes
    {
        private ArrayList FilmesCadastrados;

        public CadastroFilmes()
        {
            FilmesCadastrados = new ArrayList(); 
        }

        public void CadastrarFilme(Filme x)
        {
            FilmesCadastrados.Add(x);
        }

        public void ListarFilmes()
        {
            Console.Clear();
            foreach (Filme x in FilmesCadastrados)
            {
                if (x.Nota > 8)
                {
                    Console.WriteLine($"Título do Filme: {x.Nome}");
                    Console.WriteLine($"Diretor do Filme: {x.Diretor}");
                    Console.WriteLine($"Duração do filme: {x.Duracao}");
                    Console.WriteLine($"Nota do filme: {x.Nota}");
                    Console.WriteLine($"Mês de Lançamento: {x.Lancamento.Mes} de {x.Lancamento.Ano}");
                    Console.WriteLine($"---------------------------------------");
                    Console.WriteLine("\n");
                }
            }
        }
    }

    static void Main(string[] args)
    {
        CadastroFilmes cadastrarFilmes = new CadastroFilmes();

        do
        {
            Console.Clear();
            Filme filme = new Filme();

            Console.WriteLine("Nome do Filme: ");
            filme.Nome = Console.ReadLine();

            Console.WriteLine("Nome do Diretor: ");
            filme.Diretor = Console.ReadLine();

            Console.WriteLine("Duração do Filme: ");
            filme.Duracao = Console.ReadLine();

            Console.WriteLine("Nota do Filme: ");
            filme.Nota = int.Parse(Console.ReadLine());

            Console.WriteLine("Mês de Lançamento: ");
            filme.Lancamento.Mes = Console.ReadLine();

            Console.WriteLine("Ano de Lançamento: ");
            filme.Lancamento.Ano = Console.ReadLine();

            cadastrarFilmes.CadastrarFilme(filme);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        cadastrarFilmes.ListarFilmes();
        Console.ReadKey();
    }

}