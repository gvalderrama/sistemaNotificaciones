using System;

namespace Notificaciones
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

