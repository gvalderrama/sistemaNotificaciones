using System;
using System.IO;

namespace Notificaciones
{
	public class lectura
	{
		public lectura ()
		{
			try 
			{
				using (StreamReader sr = new StreamReader("./lectura.txt", false)) 
				{
					string line;
					while ((line = sr.ReadLine ()) != null) 
					{
						Console.WriteLine(line);
					}
				}
			} catch (Exception) 
			{
				Console.WriteLine("No se puede leer el archivo");
			}
			Console.ReadLine();
		}
	}
}

