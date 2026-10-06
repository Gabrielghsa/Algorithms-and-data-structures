using System;
using System.Collections;
class Program
{

    class Curso
    {
        private string _NomeCurso;
        private string _Coordenador;
        private Data _DataCriacao = new Data();
        private string _CargaHoraria;
        private int _ValorMensal;

        public string NomeCurso
        {
            get { return _NomeCurso; }
            set { _NomeCurso = value; }
        }

        public string Coordenador
        {
            get { return _Coordenador; }
            set { _Coordenador = value; }
        }

        public string CargaHoraria
        {
            get { return _CargaHoraria; }
            set { _CargaHoraria = value; }
        }

        public int ValorMensal
        {
            get { return _ValorMensal; }
            set { 
                if (value > 0)
                    _ValorMensal = value;
            }
        }

        public Data DataCriacao
        {
            get { return _DataCriacao; }
            set { _DataCriacao = value; }
        }

        
    }

    class Data
    {
        public string Mes;
        public string Ano;
    }
   
    class Cadastro
    {
        private Curso[] CursosCadastrados = new Curso[3];
        //private ArrayList CursosCadastrados;

        //public Cadastro(){
        //    CursosCadastrados = new ArrayList();
        //}

        public void CadastroCurso(Curso x)
        {
            for (int i = 0; i < CursosCadastrados.Length; i++)
            {
                if (CursosCadastrados[i] == null)
                {
                    CursosCadastrados[i] = x;
                    break;
                }
            }
        }

        public void ListarCursos()
        {
            Console.Clear();
            foreach(Curso x in CursosCadastrados)
            {
                if (x != null)
                {
                    if (x.ValorMensal > 1500)
                    {

                        Console.WriteLine($"Curso: {x.NomeCurso}");
                        Console.WriteLine($"Coordenador do curso: {x.Coordenador}");
                        Console.WriteLine($"Carga horária do curso: {x.CargaHoraria}");
                        Console.WriteLine($"Data da criação: {x.DataCriacao.Mes} de {x.DataCriacao.Ano}");
                        Console.WriteLine($"Valor da mensalidade: {x.ValorMensal}");
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------");
                    }
                }
            }
        }
        
    }


    static void Main(string[] args)
    {
        Cadastro cadastrarCursos = new Cadastro();
        do
        {
                Console.Clear();
                Curso curso = new Curso();

                Console.WriteLine("-----Cadastro de Cursos-----\n\n");
                Console.WriteLine("Informe o nome do curso...:");
                curso.NomeCurso = Console.ReadLine();

                Console.WriteLine("Digite o nome do Coordenador do curso...: ");
                curso.Coordenador = Console.ReadLine();

                Console.WriteLine("Digite o mês da criação do curso...: ");
                curso.DataCriacao.Mes = Console.ReadLine();

                Console.WriteLine("Digite o ano da criação do curso...: ");
                curso.DataCriacao.Ano = Console.ReadLine();

                Console.WriteLine("Digite a carga horária do curso...: ");
                curso.CargaHoraria = Console.ReadLine();

                Console.WriteLine("Digite o valor da mensalidade do curso...: ");
                curso.ValorMensal = int.Parse(Console.ReadLine());

                cadastrarCursos.CadastroCurso(curso);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        cadastrarCursos.ListarCursos();
        Console.ReadKey();
    }
}