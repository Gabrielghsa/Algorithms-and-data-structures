using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Cadastro
    {
        private Cliente[] clientes = new Cliente[100];
        
        public void lerDadosArq(string NomeArquivo)
        {
            if (File.Exists(NomeArquivo)){
                StreamReader leitor = new StreamReader(NomeArquivo);

                leitor.ReadLine();

                for (int i = 0; i < clientes.Length; i++)
                {
                    string linha = leitor.ReadLine();

                    if (linha == null)
                        break;

                    string[] dados = linha.Split(',');

                    Cliente C = criarCliente(dados);

                    clientes[i] = C;

                }

                leitor.Close();
            } else
                Console.WriteLine("ERRO: Arquivo não existe!");
        }

        private Cliente criarCliente(string[] dados)
        {
            Cliente C = new Cliente();

            C.Index = int.Parse(dados[0]);
            C.CustomerID = dados[1];
            C.FirstName = dados[2];
            C.LastName = dados[3];
            C.Company = dados[4];
            C.City = dados[5];
            C.Country = dados[6];
            C.Phone1 = dados[7];
            C.Phone2 = dados[8];
            C.Email = dados[9];
            C.SubscriptionDate = dados[10];
            C.Website = dados[11];

            return C;
        }

        public void MostrarCliente()
        {
            Console.Clear();

            foreach (Cliente C in clientes)
            {
                if (C != null)
                {
                    Console.WriteLine($"{C.Index} - {C.FirstName} - {C.LastName}");
                    Console.WriteLine($"{C.Company} - {C.City} - {C.Country}");
                    Console.WriteLine($"{C.Phone1} - {C.Phone2} = {C.Email}");
                    Console.WriteLine($"{C.SubscriptionDate} - {C.Website}");
                    Console.WriteLine("\n");
                }
            }
        }

        public void Inserir(Cliente x)
        {
            for(int i = 0; i < clientes.Length; i++)
            {
                
                if (clientes[i] == null)
                {
                    clientes[i] = x;
                    return;
                }
            }
        }

        public Cliente Pesquisar(int clienteId)
        {
            for (int i = 0; i < clientes.Length; i++) 
            {
                if (clientes[i] != null && clientes[i].Index == clienteId)
                    return clientes[i];
            }
            return null;
        }

        public bool Remover(int clienteId)
        {
            for(int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Index == clienteId)
                {
                    for (int j = i; j < clientes.Length - 1; j++)
                    {
                        clientes[j] = clientes[j + 1];
                    }
                    clientes[clientes.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
    }
}

