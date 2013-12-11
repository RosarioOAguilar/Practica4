using System.IO;
using System.Collections;
using System;

namespace Practica4
{
	
	public class Proceso
	{
				
         private ArrayList Personas = new ArrayList();
		 private Proceso persona = new Registro();
		 
		public Proceso()
		{
			Personas = new ArrayList();
			persona = new Registro();
			}
		public void Ejecutar()
		{
			leer();
		    IRegistros();
		}	

		
		  	public void leer(){
			string ruta;
			try
			{
				Console.WriteLine("Dame el archivo a leer");
				ruta = Console.ReadLine();
				
				StreamReader objReader = new StreamReader(ruta);
				
				string sLine= objReader.ReadLine();
				ArrayList arrText = new ArrayList();
	
					while (sLine != null)
					{
						ARegistro(sLine);
						sLine = objReader.ReadLine();	
					}
		             objReader.Close();
	
	
	               
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally 
			{
				Console.WriteLine("Cerrando la lectura.");
			}

		
	
					}
		public void ARegistro(string sLine)
		{
			
				char[] delimiterChars = {','};
				string[] words = sLine.Split(delimiterChars);
				
				Proceso persona = new 	Proceso();
				persona.id = words[0];
				persona.nombre = words[1];
				persona.domicilio = words[2];
				persona.telefono = words [3];
			
				Personas.Add(persona);
				
	
	
		}
		
		public void IRegistros()
		{
			Console.WriteLine("Numero de registros: "+Personas.Count);
			foreach (object Registro in Personas)
	        {
				this.persona = (Proceso) Registro;
				ITodo();
				
	        }

		}
		public void ITodo()
		{
			Console.WriteLine("----------------------------------------");
			Console.Write("ID:");
			Console.WriteLine(this.persona.id);
			Console.Write("Nombre:");
			Console.WriteLine(this.persona.nombre);
			Console.Write("Telefono:");
			Console.WriteLine(this.persona.nombre);
			Console.Write("Domicilio:");
			Console.WriteLine(this.persona.domicilio);
			Console.WriteLine("----------------------------------------");
		
			
	       }
	}
}
