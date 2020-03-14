using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beisbol
{
    class Jugadores
    {
        private int numUniforme;

        public int NumUniforme
        {
            get { return numUniforme; }
            set { numUniforme = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


    }
    class Pitcher : Jugadores
    {
        private int ponches;

        public int Ponches
        {
            get { return ponches; }
            set { ponches = value; }
        }
        private int errores;

        public int Errores
        {
            get { return errores; }
            set { errores = value; }
        }
        public override string ToString()
        {
            return ("Datos del Pitcher: \n \nNumero de jugador: " + this.NumUniforme + " \nNombre: " + this.Nombre + "\nPonches: " + this.Ponches + "\nErrores: " + this.Errores );
        }


    }
    class Posicion : Jugadores
    {
        private int hits;

        public int Hits
        {
            get { return hits; }
            set { hits = value; }
        }
        private int errores;

        public int Errores
        {
            get { return errores; }
            set { errores = value; }
        }
        public override string ToString()
        {
           return ("Datos del jugador de posicion: \n \nNumero de jugador: " + this.NumUniforme + " \nNombre: " + this.Nombre + "\nHits: " + this.Hits + "\nErrores: " + this.Errores);
        }



    }
    class Designado : Jugadores
    {
        private int hits;

        public int Hits
        {
            get { return hits; }
            set { hits = value; }
        }
        public override string ToString()
        {
            return ("Datos del jugador designado: \n \nNumero de jugador: " + this.NumUniforme + " \nNombre: " + this.Nombre+ "\nHits: " + this.Hits );
        }

    }
  
}
