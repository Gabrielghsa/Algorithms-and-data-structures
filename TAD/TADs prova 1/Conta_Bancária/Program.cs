using System;
using System.Collections;
class Program
{

    class Conta
    {
        private string _NomeTitular;
        private string _NumeroConta;
        private decimal _Saldo;

        public string NomeTitular
        {
            get { return _NomeTitular; }
            set { _NomeTitular = value; }
        }

        public string NumeroConta
        {
            get { return _NumeroConta; }
            set { _NumeroConta = value; }
        }

        public decimal Saldo
        {
            get { return _Saldo; }
            set
            {
                if (value >= 0)
                    _Saldo = value;
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
                Console.WriteLine($"Deposito de R${valor:f2} relizado com sucesso! Saldo atuak R${Saldo:f2}");
            }
        }

        public void Sacar(decimal valor)
        {
            if (valor >= 0) {
                if (Saldo >= valor) {
                    Saldo -= valor;
                    Console.Write($"Saque realizado com sucesso! Saldo atual R${Saldo:f2}");
                }
            }else
                Console.WriteLine($"Saldo Insuficiente!!! Saldo atual R${Saldo:f2}");      
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo atual: R${Saldo:f2}");
        }

        public void DadosCliente() 
        {
            Console.Clear();
            Console.WriteLine($"Nome do títular: {NomeTitular}");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Saldo da conta: R${Saldo:f2}");
        }
    }

    class Cadastro
    {
        private ArrayList ClientesCadastrados;

        public Cadastro()
        {
            ClientesCadastrados = new ArrayList();
        }

        public void CadastrarCliente(Conta x)
        {
            ClientesCadastrados.Add(x);
        }
    }


    static void Main(string[] args)
    {

        Conta cliente1 = new Conta();

        cliente1.NomeTitular = "Macrebinho";
        cliente1.NumeroConta = "29.811";

        cliente1.Depositar(500);

        cliente1.Sacar(200);

        cliente1.DadosCliente();
        Console.ReadKey();
    }
}