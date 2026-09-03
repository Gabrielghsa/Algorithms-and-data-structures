using System; 
class Program
{
    static int SomaVetor(int[] vetor, int indice, int resultado)
    {
        if (indice == vetor.Length)
            return resultado;
        return SomaVetor(vetor, indice + 1, resultado + vetor[indice]);
    }
    static void Main(string[] args)
    {
        
        int[] vetor = {10, 20, 30, 40};
        int resultadoSoma = SomaVetor(vetor, 0, 0);
        Console.Write(resultadoSoma);
        Console.ReadKey();
    }
}