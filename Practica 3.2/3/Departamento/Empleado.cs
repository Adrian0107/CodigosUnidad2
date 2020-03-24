using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departamento
{
    class Empleado
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private int telefono;

		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}
		private string correoElectronico;

		public string CorreoElectronico
		{
			get { return correoElectronico; }
			set { correoElectronico = value; }
		}
	}
}
