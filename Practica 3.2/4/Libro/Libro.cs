using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libro
{
    class Libro
    {
		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		private string autor;

		public string Autor
		{
			get { return autor; }
			set { autor = value; }
		}
		private string editorial;

		public string Editorial
		{
			get { return editorial; }
			set { editorial = value; }
		}
		private string isbn;

		public string ISBN
		{
			get { return isbn; }
			set { isbn = value; }
		}
		List<Capitulo> listaCapitulos;
		public Libro()
		{
			listaCapitulos = new List<Capitulo>();
		}
		public void InsertarCapitulo(Capitulo capitulo)
		{
			listaCapitulos.Add(capitulo);
		}
		public IEnumerator<Capitulo> GetEnumerator()
		{
			return listaCapitulos.GetEnumerator();
		}
		~Libro()
		{
			listaCapitulos.Clear();
		}



	}
}
