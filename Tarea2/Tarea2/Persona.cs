
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Tarea2
{

	public class Persona
	{
		public string nombre;
        public string numeroasociado;
		public int edad;
		
		public Persona(){
			this.nombre = "";
			this.edad = 0;
            this.numeroasociado= "";
		}
		
		
		
		public virtual String informacion(){
			return "Información de la persona \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad + "\n" +
                    "numero de asociado:"+ this.numeroasociado;
		}
	}
}



