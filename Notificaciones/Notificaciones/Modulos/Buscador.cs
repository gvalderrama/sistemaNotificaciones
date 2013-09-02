
using System;
using System.IO;
using System.Security.Permissions;


namespace Notificaciones
{
	public class Buscador
	{
		public Buscador ()
		{
			// Crea un nuevo FileSystemWatcher y establecer sus propiedades.
			FileSystemWatcher Buscador = new FileSystemWatcher();
			Buscador.Path = //ruta del archivo a monitoriar
			/* Esté atento a los cambios en LastAccess y tiempos LastWrite y
				el cambio de nombre de archivos o directorios. */
			Buscador.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
				| NotifyFilters.FileName | NotifyFilters.DirectoryName;
			//Especifica ver sólo archivos de texto.
			Buscador.Filter = "*.txt";
			
			// Agregar controladores de eventos.
			Buscador.Changed += new FileSystemEventHandler(OnChanged);
			Buscador.Created += new FileSystemEventHandler(OnChanged);
			Buscador.Deleted += new FileSystemEventHandler(OnChanged);
			Buscador.Renamed += new RenamedEventHandler(OnRenamed);
			
			// comenzar a monitoriar los eventos
			Buscador.EnableRaisingEvents = true;
			

		}
		
		// Definir los controladores de eventos.
		private static void OnChanged(object source, FileSystemEventArgs e)
		{
			// Especifique lo que se hace cuando se cambia un archivo, creado o eliminado.
			Console.WriteLine("File: " +  e.FullPath + " " + e.ChangeType);
		}
		
		private static void OnRenamed(object source, RenamedEventArgs e)
		{
			// Especifique lo que se hace cuando se cambia el nombre de un archivo.
			Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
		}
	}
	

		}
	


