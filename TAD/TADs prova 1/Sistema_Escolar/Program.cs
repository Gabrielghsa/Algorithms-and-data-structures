using System;
using System.Collections;
class Program
{

    class Professor
    {
        private string _Nome;
        private int _IdProfessor;
        private decimal _Salario;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public int IdProfessor
        {
            get { return _IdProfessor; }
            set { 
                if(value > 0)
                    _IdProfessor = value;
            }
        }

        public decimal Salario
        {
            get { return _Salario; }
            set
            {
                if (value > 0)
                    _Salario = value;
            }
        }
    }

    class Curso
    {
        private string _Nome;
        private string _Coordenador;
        private Professor[] _Professores = new Professor[2];

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Coordenador
        {
            get { return _Coordenador; }
            set { _Coordenador = value; }
        }

        public Professor[] Professores
        {
            get { return _Professores; }
            set { _Professores = value; }
        }
    }

    class Cadastro
    {
        private ArrayList CursosCadastrados;
        private ArrayList ProfessoresCadastrados;

        public Cadastro()
        {
            CursosCadastrados = new ArrayList();
        }

        public void CadastrarCurso(Curso x)
        {
            CursosCadastrados.Add(x);
        }

        public void ListarCursos()
        {
            Console.Clear();

            foreach (Curso x in CursosCadastrados)
            {
                Console.WriteLine($"Nome do Curso: {x.Nome}");
                Console.WriteLine($"Coordenador do Curso: {x.Coordenador}");
                if (x.Professores[0] != null && x.Professores[1] != null)
                    Console.WriteLine($"Professores do Curso: {x.Professores[0].Nome} e {x.Professores[1].Nome}");
                else
                    Console.WriteLine("Cada curso precisa obrigatóriamente de 2 professores");
                Console.WriteLine("\n");
            }
        }
    }

    static void Main(string[] args)
    {
        Cadastro cadastrar = new Cadastro();

        do
        {
            Console.Clear();
            Curso curso = new Curso();
            

            Console.WriteLine("Nome do Curso: ");
            curso.Nome = Console.ReadLine();
            Console.WriteLine("Coordenador do Curso: ");
            curso.Coordenador = Console.ReadLine();

            Console.WriteLine("Professor 1 do Curso: ");


            Professor professor1 = new Professor();
            Console.WriteLine("Nome do Professor: ");
            professor1.Nome = Console.ReadLine();

            Console.WriteLine("Id do Professor: ");
            professor1.IdProfessor = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário do Professor: ");
            professor1.Salario = decimal.Parse(Console.ReadLine());

            

            Console.WriteLine("Professor 2 do Curso: ");

            Professor professor2 = new Professor();

            Console.WriteLine("Nome do Professor: ");
            professor2.Nome = Console.ReadLine();

            Console.WriteLine("Id do Professor: ");
            professor2.IdProfessor = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário do Professor: ");
            professor2.Salario = decimal.Parse(Console.ReadLine());

            
            curso.Professores[0] = professor1;
            curso.Professores[1] = professor2;
            cadastrar.CadastrarCurso(curso);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        cadastrar.ListarCursos();

       Console.ReadKey();
    }
}