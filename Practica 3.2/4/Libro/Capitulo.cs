using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    class Capitulo
    {
		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		private int cantidadPaginas;

		public int CantidadPaginas
		{
			get { return cantidadPaginas; }
			set { cantidadPaginas = value; }
		}



	}
}
