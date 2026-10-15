using System;
class Program
{
    static int InserirPaciente(string[] pacientes, int quantidade, string xPaciente)
    {
        if(quantidade < pacientes.Length)
        {
            pacientes[quantidade] = xPaciente;
            quantidade++;        
        }else
            Console.WriteLine("Sem lugar disponível!!!");
        return quantidade;
    }

    static void Main(string[] args)
    {
        string[] pacientes = new string[10];
        int qtd = 0;

        Console.WriteLine("Quantos pacientes serão? ");
        int qtdPacientes = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtdPacientes; i++) {
            Console.WriteLine("Informe o nome do paciente: ");
            string pacienteNovo = Console.ReadLine();
            qtd = InserirPaciente(pacientes, qtd, pacienteNovo);
        }

        Console.WriteLine("\n");
        for (int i = 0; i < qtd; i++) {
            Console.WriteLine($"{pacientes[i]}");
        }

        Console.ReadKey();
    }
}