using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ListaJogos
{
    class Program
    {

        static int LerInt()
        {
            int x;

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Valor inválido! Digite um número inteiro:");
            }

            return x;
        }

        static void CadastrarJogo(InfosJogo NovoJogo)
        {
            System.Console.Write("Código: ");
            NovoJogo.Codigo = LerInt();

            System.Console.Write("Nome: ");
            NovoJogo.Nome = Console.ReadLine() ?? "";

            System.Console.Write("Genêro: ");
            NovoJogo.Genero = Console.ReadLine() ?? "";

            System.Console.Write("Dia do lançamento: ");
            NovoJogo.Lancamento.Dia = LerInt();

            System.Console.Write("Mês do lançamento: ");
            NovoJogo.Lancamento.Mes = LerInt();

            System.Console.Write("Ano do lançamento: ");
            NovoJogo.Lancamento.Ano = LerInt();

            System.Console.Write("Preço: ");
            NovoJogo.Preco = LerInt();

            System.Console.WriteLine("Nota");
            NovoJogo.Nota = LerInt();
        }

        static void CadastrarInicio(InfosJogo NovoJogo)
        {
            System.Console.Write("Código: ");
            NovoJogo.Codigo = LerInt();

            System.Console.Write("Nome: ");
            NovoJogo.Nome = Console.ReadLine() ?? "";

            System.Console.Write("Genêro: ");
            NovoJogo.Genero = Console.ReadLine() ?? "";

            System.Console.Write("Dia do lançamento: ");
            NovoJogo.Lancamento.Dia = LerInt();

            System.Console.Write("Mês do lançamento: ");
            NovoJogo.Lancamento.Mes = LerInt();

            System.Console.Write("Ano do lançamento: ");
            NovoJogo.Lancamento.Ano = LerInt();

            System.Console.Write("Preço: ");
            NovoJogo.Preco = LerInt();

            System.Console.WriteLine("Nota");
            NovoJogo.Nota = LerInt();
        }


        static void Main(string[] args)
        {
            Lista ListaJogos = new Lista();
            int op;
            do
            {

                Console.Clear();
                Console.WriteLine("=======CADASTRO DE JOGOS========");
                System.Console.WriteLine("=  1 - Cadastrar Novo Jogo     =");
                System.Console.WriteLine("=  2 - Inserir Jogo no Inicío  =");
                System.Console.WriteLine("=  3 - Remover Jogo (Código)   =");
                System.Console.WriteLine("=  4 - Pesquisar um Jogo (Cód) =");
                System.Console.WriteLine("=  5 - Qtde de Jogos no Lista  =");
                System.Console.WriteLine("=  6 - Mostrar Lista           =");
                Console.WriteLine("================================\n");


                op = LerInt();

                if (op == 1)
                {
                    InfosJogo NovoJogo = new InfosJogo();
                    CadastrarJogo(NovoJogo);
                    ListaJogos.InserirFim(NovoJogo);
                }
                else if (op == 2)
                {

                    InfosJogo NovoJogo = new InfosJogo();
                    CadastrarInicio(NovoJogo);
                    

                    ListaJogos.InserirInicio(NovoJogo);

                }
                else if (op == 3)
                {
                    int codJogo;
                    System.Console.Write("Digite o Código: ");
                    if (int.TryParse(Console.ReadLine(), out int cod))
                        codJogo = cod;
                    else
                    {
                        System.Console.WriteLine("Código Inválido!!!");
                        return;
                    }

                    System.Console.WriteLine("Jogo Removido da Lista");
                    ListaJogos.RemoverJogo(codJogo);

                    

                }
                else if (op == 4)
                {
                    int codJogo;
                    System.Console.Write("Digite o Código: ");
                    if (int.TryParse(Console.ReadLine(), out int cod))
                        codJogo = cod;
                    else
                    {
                        System.Console.WriteLine("Código Inválido!!!");
                        return;
                    }

                    ListaJogos.Pesquisar(codJogo);

                }
                else if (op == 5)
                {
                    System.Console.WriteLine($"Qtde de Jogos Cadastrados: {ListaJogos.QtdJogos()}");
                    Console.ReadKey();


                }
                else if (op == 6)
                {
                    System.Console.WriteLine("Jogos Cadastrados na Lista: ");
                    ListaJogos.ExibirLista();
                    System.Console.WriteLine("\n");

                }


            } while (op != 0);
        }
    }
}
