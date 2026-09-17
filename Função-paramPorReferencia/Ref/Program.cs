using System;
class Program
{
    static void Main(string[] args)
        {
            int[] Vetor = new int[10];

            Random x = new Random();

            int Maior, Menor;
            double Média=0;

            double Raio;
            double Área, Perímetro;

            Console.WriteLine("Vetor de Números Aleatórios: \n");
            
            for(int i = 0; i < 10; i++)
            {
                Vetor[i] = x.Next(0, 50);

                Console.Write($"{Vetor[i],7}");
            }

            Maior = AchaMaior(Vetor);
            Menor = AchaMenor(Vetor);

            CalcMédia(Vetor, ref Média);

            Console.WriteLine($"\n\nMaior inteiro no Vetor: {Maior}");
            Console.WriteLine($"Menor inteiro no Vetor: {Menor}");
            Console.WriteLine($"Média dos Valores.....: {Média}\n\n");

            MudaValoresVetor(Vetor);

            Console.WriteLine("Vetor com Números Alterados: \n");

            // Mostra o Vetor com outros valores...
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{Vetor[i],7}");
            }

            Console.ReadKey(true);

            Console.Clear();

            Console.Write("Raio do Círculo: ");
            Raio = double.Parse(Console.ReadLine());

            (Área, Perímetro) = CalcÁreaPerímetro(Raio);

            Console.WriteLine($"\nÁrea do Círculo: {Área:F2}");
            Console.WriteLine($"Perímetro......: {Perímetro:F2}");

            Console.ReadKey();

            Console.WriteLine($"\n\nO primeiro valor é o da Área....: {CalcÁreaPerímetro(Raio).Item1:F2}");
            Console.WriteLine($"\nO segundo valor é o do Perímetro: {CalcÁreaPerímetro(Raio).Item2:F2}");

            Console.ReadKey();
        }

        static int AchaMaior(int[] V)       // Passagem de Parâmetros por Valor
        {
            int Maior = V[0];

            for (int i = 1; i < 10; i++)
            {
                if (V[i] > Maior)
                    Maior = V[i];
            }

            return Maior;

        }

        static int AchaMenor(int[] V)
        {
            int Menor = V[0];

            for (int i = 1; i < 10; i++)
            {
                if (V[i] < Menor)
                    Menor = V[i];
            }

            return Menor;
        }

        static void CalcMédia(int[] V, ref double Média)        // Parâmetro por Referência
        {
            int Soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Soma += V[i];
            }

            Média = (double)Soma / 10;
        }

        static void MudaValoresVetor(int[] V)
        {
            for(int i = 0; i < 10; i++)
            {
                V[i] = V[i] + 25;
            }
        }

        static (double,double) CalcÁreaPerímetro(double R)
        {
            double A = Math.PI * Math.Pow(R, 2);
            double P = 2 * Math.PI * R;

            return (A, P);
        }
    
}