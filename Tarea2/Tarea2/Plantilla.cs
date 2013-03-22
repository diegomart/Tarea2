using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea2
{
    class Plantilla

	{
		public void Multifuncional(){
			Multifuncional multifuncional = new Multifuncional();
			multifuncional.nombre = "Juan Diego";
			multifuncional.edad = 20;
			multifuncional.numeroasociado= "6648911";
	
			multifuncional.activo();
		
			
			//Polimorfismo	
			Persona persona = multifuncional;
		
			Console.WriteLine(persona.informacion());
		
		}

        public void Gerente()
        {
            Gerente gerente = new Gerente();
            gerente.nombre = "Mario Rodriguez";
            gerente.edad = 30;
            gerente.numeroasociado = "3443423";
            gerente.area = "Bodega AUrrera";
            gerente.nombrarLista();
       		
			//Polimorfismo	
			Persona persona = gerente;
			Console.WriteLine(persona.informacion());
		}
		
		public static void Main (string[] args)
		{
			Plantilla programa = new Plantilla();
			programa.Multifuncional();
			programa.Gerente();
			
		}
	}
}

