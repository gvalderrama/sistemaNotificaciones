using System;
using Gtk;

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

		}
	}
}