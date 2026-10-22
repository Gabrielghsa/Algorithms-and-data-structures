using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace ListaJogos
{
    class InfosJogo
    {
        private int _Codigo;
        private string _Nome;
        private string _Genero;
        private Data _Lancamento;
        private decimal _Preco;
        private int _ClassificacaoIndicativa;

        public int Codigo
        {
            get { return _Codigo; }
            set
            {
                if (value >= 0)
                    _Codigo = value;
            }
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Genero
        {
            get { return _Genero; }
            set { _Genero = value; }
        }

        public decimal Preco
        {
            get { return _Preco; }
            set
            {
                if (value >= 0)
                    _Preco = value;
            }
        }

        public Data Lancamento
        {
            get { return _Lancamento; }
            set { _Lancamento = value; }
        }

        public int ClassificacaoIndicativa
        {
            get { return _ClassificacaoIndicativa; }
            set
            {
                if (value >= 0 && value <= 18)
                    _ClassificacaoIndicativa = value;
            }
        }
    }

    class Data
    {
        private int _Dia;
        private int _Mes;
        private int _Ano;

        public int Dia
        {
            get { return _Dia; }
            set
            {
                if (value < 1 || value > DateTime.DaysInMonth(_Mes, _Ano))
                    throw new ArgumentOutOfRangeException($"Dia inválido para o mês {_Mes} do ano {_Ano}.");
                _Dia = value;
            }
        }

        public int Mes
        {
            get { return _Mes; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("O mês deve estar entre 1 e 12!!!");
                _Mes = value;
            }
        }

        public int Ano
        {
            get { return _Ano; }
            set
            {
                if (value < 1947 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException("O ano deve ser entre 1947 e o ano atual!!!");
                _Ano = value;
            }
        }
    }
}