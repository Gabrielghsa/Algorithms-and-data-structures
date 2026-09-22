using System;
class Program
{
    class Livro
    {
        private string _Isbn;
        private string _Titulo;
        private string _Autor;
        private bool _Disponivel;

        public string Isbn
        {
            get { return _Isbn; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Autor
        {
            get { return _Autor; }

        }

        public bool Disponivel
        {
            get { return _Disponivel; }

        }
        public Livro(string isbn, string titulo, string autor)
        {
            _Isbn = isbn;
            _Titulo = titulo;
            _Autor = autor;
            _Disponivel = true;
        }

        public void Emprestar()
        {
            if (_Disponivel)
            {
                _Disponivel = false;
                Console.Write($"Livro {Titulo} alugado");
            }
            else
                Console.Write($"Livro {Titulo} está indisponível no momento");
        }

        public void Devolver()
        {
            if (!_Disponivel)
            {
                _Disponivel = true;
                Console.Write($"Livro {Titulo} devolvido. Obrigado!");
            }
            else
                Console.Write($"O livro {Titulo} não está emprestado, portanto não pode ser devolvido.\n");
        }
    }

    class Usuario
    {
        private string _Matricula;
        private string _Nome;
        private string _Email;



        public string Matricula
        {
            get { return _Matricula; }

        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Email
        {
            get { return _Email; }

        }

        public Usuario(string matricula, string nome, string email)
        {
            _Matricula = matricula;
            _Nome = nome;
            _Email = email;
        }

        public void ExibirDados()
        {
            Console.Write($"Usuário {Nome}\n");
            Console.Write($"Matricula {Matricula}\n");
            Console.Write($"Email {Email}");
        }

        public void PegarLivro(Livro livro)
        {
            livro.Emprestar();
        }


    }


    static void Main(string[] args)
    {
        Livro Metamorfose = new Livro("3456", "A Metarmofose", "Franz Kafka");
    }
}