using System;
using Gtk;
using System.IO;

namespace Notificaciones
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			//Buscador objeto = new Buscador();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
			Console.WriteLine("comprovado");

			//Se crear un archivo de texto
			string fecha = "hola";
			Historial historial = new Notificaciones.Historial(fecha);
		}
	}
}