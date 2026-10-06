using System;
class Program
{

    class Aluno
    {
        private string _Nome;
        private double _Peso;
        private double _Altura;
        private double _IMC;
        private Data _DataMatricula = new Data();

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public double Peso
        {
            get { return _Peso; }
            set
            {
                if (value > 0)
                    _Peso = value;
            }
        }

        public double Altura
        {
            get { return _Altura; }
            set
            {
                if (value > 0)
                    _Altura = value;
            }
        }

        public double IMC
        {
            get { return Peso / (Math.Pow(Altura, 2)); }
        
        }

        public Data DataMatricula
        {
            get { return _DataMatricula; }
            set { _DataMatricula = value; }
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

    class Dados
    {
        private Aluno[] alunosCadastrados;

        public Dados(int qtd)
        {
            alunosCadastrados = new Aluno[qtd];
        }

        public void CadastrarAluno(Aluno x)
        {
            for (int i = 0; i < alunosCadastrados.Length; i++)
            {
                if (alunosCadastrados[i] == null)
                {
                    alunosCadastrados[i] = x;
                    break;
                }
            }
        }

        public void ListarAlunos()
        {
            Console.Clear();
            foreach(Aluno x in alunosCadastrados)
            {
                if(x != null)
                {
                    if(x.IMC > 25)
                    {
                        Console.WriteLine($"Nome do Aluno: {x.Nome}");
                        Console.WriteLine($"IMC do Aluno: {x.IMC:f2}");
                        Console.WriteLine("-------------------");
                        Console.Write("\n\n");
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Quantos alunos serão cadastrados hoje? ");
        int qtd = int.Parse(Console.ReadLine());

        Dados dadosAluno = new Dados(qtd);

        for (int i = 0; i < qtd; i++) { 
            Aluno aluno = new Aluno();
           
            Console.Clear();

            Console.WriteLine("------Cadastro de Alunos------\n\n");

            Console.WriteLine($"Digite o Nome do Novo Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o Peso do Aluno: ");
            aluno.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a Altura do Aluno: ");
            aluno.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Mês da Matrícula: ");
            aluno.DataMatricula.Mes = Console.ReadLine();

            Console.WriteLine($"Digite o Ano da Matrícula: ");
            aluno.DataMatricula.Ano = Console.ReadLine();

            dadosAluno.CadastrarAluno(aluno);
        }
        dadosAluno.ListarAlunos();
        Console.ReadKey();
    }
}