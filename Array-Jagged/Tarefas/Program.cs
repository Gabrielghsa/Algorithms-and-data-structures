using System;
class Program
{
    static void Main(string[] args)
    {
        int qtdDias;
        int qtdTarefas = 0;

        Console.Write("Informe a quantidade de dias: ");
        qtdDias = int.Parse(Console.ReadLine());

        string[][] tarefasPorDia = new string[qtdDias][];

        //Adicionando os valores
        for (int i = 0; i < qtdDias; i++)
        {
            Console.Write("Informe a quantidade de tarefas diárias: ");
            qtdTarefas = int.Parse(Console.ReadLine());
            tarefasPorDia[i] = new string[qtdTarefas];
            

            for (int j = 0; j < qtdTarefas; j++)
            {
                Console.Write($"Informe a {j + 1}° do {i + 1}° dia: ");
                tarefasPorDia[i][j] = Console.ReadLine();
            }
        }

        //Litagem
        for (int i = 0; i < tarefasPorDia.Length; i++)
        {
            Console.WriteLine("\nDia {0}", i + 1);

            for (int j = 0; j < tarefasPorDia[i].Length; j++)
            {
                Console.WriteLine($"       ==> {tarefasPorDia[i][j]}");
            }
        }
        Console.ReadKey();
    }
}