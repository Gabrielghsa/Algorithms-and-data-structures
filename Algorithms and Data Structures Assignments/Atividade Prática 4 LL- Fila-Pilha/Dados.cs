using System;
using System.Collections;
using System.Linq;
using System.Text;
using FilaPilha;

namespace FilaPilha
{
	
	public class Pessoa
	{
		private string _Nome;
		private int _Id;

		public string Nome { 
			get { return _Nome; } 
			set { _Nome = value; }
		}

		public int Id
		{
			get { return _Id; }
			set
			{
				if (value >= 0)
					_Id = value;
			}
		}
	}
}
