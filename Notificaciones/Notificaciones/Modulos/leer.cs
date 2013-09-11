using System;
using System.IO;
using System.Text;

namespace tex
{
	public class leer
	{
	
			public string lectura () {
	
			
    string path = "./mensajeuno.txt";
    Stream abrir = File.OpenRead(path);
			
    // crear buffer para abrir stream
			
	BufferedStream lector = new BufferedStream(abrir);
    
  	string  devolver =  lector.ToString();
			
			return devolver;	
			
			}	
		}
	}


