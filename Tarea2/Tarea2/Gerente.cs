using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{
    

	public class Gerente : Persona
	{
		public string codigo;
		public string area;
		
		public Gerente ()
		{
		}
		
		public void nombrarLista(){
			Console.WriteLine("Gerente con el código " + this.codigo +" y nombre " + this.nombre +" ssu area es  " + this.area + ".");
			Console.WriteLine();
		}
		
		
		public override String informacion(){
			return "Información del profesor \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"Código :" + this.numeroasociado + "\n" +
					"Materia :" + this.area + "\n";
		}
	}
}



