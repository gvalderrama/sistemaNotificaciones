using System;

namespace EjemploVentana
{
	public partial class Mensaje : Gtk.Window
	{
		public Mensaje () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

