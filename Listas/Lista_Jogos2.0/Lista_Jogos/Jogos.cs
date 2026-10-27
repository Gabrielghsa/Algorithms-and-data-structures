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
        private string _Nome = "";
        private string _Genero = "";
        private Data _Lancamento = new Data();
        private decimal _Preco;
        private int _Nota;

        public int Codigo
        {
            get {return _Codigo;}
            set
            {
                if(value >= 0)
                    _Codigo = value;
            }
        }

        public string Nome
        {
            get {return _Nome;}
            set {_Nome = value;}
        }

        public string Genero
        {
            get {return _Genero;}
            set {_Genero = value;}
        }

        public decimal Preco
        {
            get {return _Preco;}
            set
            {
                if(value >= 0)
                    _Preco = value;
            }
        }

        public Data Lancamento
        {
            get {return _Lancamento;}
            set {_Lancamento = value;}
        }

        public int Nota
        {
            get{return _Nota;}
            set
            {
                if(value >= 0 && value <= 10)
                    _Nota = value;
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
            get {return _Dia;}
            set
            {
                if(value >= 1 && value <= 31)
                    _Dia = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "O dia deve estar entre 1 e 31!!!");
               
            }
        }

        public int Mes
        {
            get {return _Mes;}
            set
            {
                if(value >= 1 && value <= 12)
                    _Mes = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "O mês deve estar entre 1 e 12!!!");
                
            }
        }

        public int Ano
        {
            get {return _Ano;}
            set
            {
                if(value >= 1947 && value <= DateTime.Now.Year)
                    _Ano = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "O ano deve ser entre 1947 e o ano atual!!!");
            }
        }
    }
}
