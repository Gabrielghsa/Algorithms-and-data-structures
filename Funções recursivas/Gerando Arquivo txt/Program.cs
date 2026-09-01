using System;
using System.IO;
class Program
{
    static StreamWriter arqGerado = new StreamWriter(@"C:\arquivos\arqGerado_out.txt");
    private static void GerarArquivo(int numeroArquivo)
    {
        string caminhoArquivo = @"C:\arquivos\arq" + numeroArquivo + ".txt";
        if (File.Exists(caminhoArquivo))
        {
            using (StreamReader arquivo = File.OpenText(caminhoArquivo)) {
                string linha;
                while ((linha = arquivo.ReadLine()) != null) {
                    arqGerado.WriteLine(linha);
                }
            }
            GerarArquivo(numeroArquivo + 1);
        }
    }
        static void Main(string[] args)
        {

            GerarArquivo(1);
            arqGerado.Close();
        }
}