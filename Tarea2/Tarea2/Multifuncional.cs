using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{

public class Multifuncional : Persona
	{
		public string codigo;
		
		
		public Multifuncional()
		{
		}
		
		public void activo(){
			Console.WriteLine("El mmultifuncional con el código " + this.codigo +" y nombre " + this.nombre +" se encuentra activo.");
			Console.WriteLine();
		}
		
		
		
		public override String informacion(){
			return "Información del alumno \n" +
					"Nombre :" + this.nombre + "\n" +
					"Edad:" + this.edad+ "\n" +
					"Código :" + this.numeroasociado + "\n" ;
		}
	}
}

