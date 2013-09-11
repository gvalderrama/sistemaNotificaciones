
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
			FileSystemWatcher Bu = new FileSystemWatcher();
			string ruta="./";
			Bu.Path = ruta;
			/* Esté atento a los cambios en LastAccess y tiempos LastWrite y
				el cambio de nombre de archivos o directorios. */
			Bu.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
				| NotifyFilters.FileName | NotifyFilters.DirectoryName;
			//Especifica ver sólo archivos de texto.
			Bu.Filter = "*.txt";
			
			// Agregar controladores de eventos.
			Bu.Changed += new FileSystemEventHandler(OnChanged);
			Bu.Created += new FileSystemEventHandler(OnChanged);
			Bu.Deleted += new FileSystemEventHandler(OnChanged);
			Bu.Renamed += new RenamedEventHandler(OnRenamed);
			
			// comenzar a monitoriar los eventos
			Bu.EnableRaisingEvents = true;
			

		}

		// Definir los controladores de eventos.
		private static void OnChanged(object source, FileSystemEventArgs e)
		{
			// Especifique lo que se hace cuando se cambia un archivo, creado o eliminado.
			System.Console.WriteLine("File: " +  e.FullPath + " " + e.ChangeType);


		}

		private static void OnRenamed(object source, RenamedEventArgs e)
		{
			// Especifique lo que se hace cuando se cambia el nombre de un archivo.
			System.Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
		}
	}
	

		}
	


