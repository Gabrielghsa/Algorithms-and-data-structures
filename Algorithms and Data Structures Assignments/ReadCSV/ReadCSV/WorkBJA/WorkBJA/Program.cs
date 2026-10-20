using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.Threading;

namespace WorkBJA
{
    class Program
    {
        static void Main(string[] Args)
        {
            Cadastro MeuCadastro = new Cadastro();

            int op;
            do
            {
                Console.Clear();

                Console.WriteLine("===== SISTEMA DE CLIENTES =====");
                Console.WriteLine("1 - Ler arquivo");
                Console.WriteLine("2 - Mostrar clientes");
                Console.WriteLine("3 - Remover Cliente");
                Console.WriteLine("4 - Pesquisar cliente");
                Console.WriteLine("5 - Inserir cliente");
                Console.Write("\nEscolha uma opção: ");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        
                        MeuCadastro.lerDadosArq(@"..\..\customers-100.csv"); 
                        break;

                    case 2:

                        MeuCadastro.MostrarCliente();
                        break;

                    case 3:
                        Console.Write("Informe o identificador ID do cliente: ");
                        int indexCliente = int.Parse(Console.ReadLine());

                        bool removido = MeuCadastro.Remover(indexCliente);

                        if (removido)
                            Console.WriteLine("\nCliente removido com sucesso!");
                        else
                            Console.WriteLine("\nCliente não encontrado!");

                        break;

                    case 4:
                        Console.Write("Informe o identificador ID do cliente: ");
                        int index = int.Parse(Console.ReadLine());

                        Cliente clientePesquisado = MeuCadastro.Pesquisar(index);

                        if (clientePesquisado != null)
                        {
                            Console.WriteLine("\nCliente encontrado!");
                            Console.WriteLine($"{clientePesquisado.Index} - {clientePesquisado.FirstName} - {clientePesquisado.LastName}");
                            Console.WriteLine($"{clientePesquisado.Company} - {clientePesquisado.City} - {clientePesquisado.Country}");
                            Console.WriteLine($"{clientePesquisado.Phone1} - {clientePesquisado.Phone2}");
                            Console.WriteLine($"{clientePesquisado.Email}");
                            Console.WriteLine($"{clientePesquisado.SubscriptionDate} - {clientePesquisado.Website}");
                        }
                        else
                            Console.WriteLine("\nCliente não encontrado!");
                        break;

                    case 5:
                        Cliente novoCliente = new Cliente();

                        Console.Write("Digite o Index: ");
                        novoCliente.Index = int.Parse(Console.ReadLine());

                        Console.Write("Digite o Customer ID: ");
                        novoCliente.CustomerID = Console.ReadLine();

                        Console.Write("Digite o primeiro nome: ");
                        novoCliente.FirstName = Console.ReadLine();

                        Console.Write("Digite o sobrenome: ");
                        novoCliente.LastName = Console.ReadLine();

                        Console.Write("Digite a empresa: ");
                        novoCliente.Company = Console.ReadLine();

                        Console.Write("Digite a cidade: ");
                        novoCliente.City = Console.ReadLine();

                        Console.Write("Digite o país: ");
                        novoCliente.Country = Console.ReadLine();

                        Console.Write("Digite o telefone 1: ");
                        novoCliente.Phone1 = Console.ReadLine();

                        Console.Write("Digite o telefone 2: ");
                        novoCliente.Phone2 = Console.ReadLine();

                        Console.Write("Digite o e-mail: ");
                        novoCliente.Email = Console.ReadLine();

                        Console.Write("Digite a data de inscrição: ");
                        novoCliente.SubscriptionDate = Console.ReadLine();

                        Console.Write("Digite o website: ");
                        novoCliente.Website = Console.ReadLine();

                        MeuCadastro.Inserir(novoCliente);

                        Console.WriteLine("\nCliente inserido com sucesso!");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}








