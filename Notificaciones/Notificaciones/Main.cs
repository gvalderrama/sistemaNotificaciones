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
			Buscador objeto = new Buscador();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
			Console.WriteLine("comprovado");

			//Se crear un archivo de texto
			StreamWriter writer = File.CreateText("./Archivo.txt");
            writer.WriteLine("Escribo lo que quiero");
            writer.Close();
			Console.WriteLine("El Archivo fue Credo en la");
			Console.WriteLine("Fecha Actual: " + DateTime.Now.ToString("yyyy/MM/dd\nHH:mm:ss"));
			Console.WriteLine("Y");
			Console.WriteLine("Hora Señalada: " + DateTime.Now.ToShortTimeString());

		}
	}
}