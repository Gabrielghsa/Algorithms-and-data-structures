using System; 
class Program
{
    class Funcionario
    {
        public string Nome;
        public Data DataNasc = new Data();
        public double Salario;
    }

    class Data
    {
        public string Dia;
        public string Mes;
    } 

    static void Main(string[] args)
    {

        Funcionario[] Cadastro = new Funcionario[3];

        for (int i = 0; i < 3; i++) { 
            Funcionario F = new Funcionario();

            Console.Write("Digite seu nome... ");
            F.Nome = Console.ReadLine();

            Console.Write("     Digite a data de nascimento - Dia... ");
            F.DataNasc.Dia = Console.ReadLine();

            Console.Write("     Digite a data de nascimento - Mês... ");
            F.DataNasc.Mes = Console.ReadLine();

            Console.Write("     Digite o seu salário... ");
            F.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Cadastro[i] = F;
        }
        Console.Clear();

        foreach(Funcionario F in Cadastro)
        {
            Console.WriteLine($"{F.Nome,3} {F.DataNasc.Dia} de {F.DataNasc.Mes,3} R${F.Salario}\n");
        }
        Console.ReadKey();
    }
}