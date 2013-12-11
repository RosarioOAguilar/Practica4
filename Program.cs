using System.IO;
using System.Collections;
using System;

namespace Practica4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Proceso proceso = new Proceso();
			Console.WriteLine("Practica no.4 Excepciones! CSV PARSER  ");
			Console.ReadKey(true);
			proceso.leer();
			proceso.ARegistro();
			proceso.IRegistros();
			proceso.ITodo();
			
			
		}	
}		
			public class Registro
	        {
	
			//public string 	id;
			//public string   nombre;
			//public string   domicilio;
			//public string   telefono;
			
			public Registro(){
				
				public string 	id;
			    public string   nombre;
			    public string   domicilio;
			    public string   telefono;
			
			
	        }
	}	
}
