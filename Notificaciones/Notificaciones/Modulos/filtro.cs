using System;
using System.IO;
using System.Text;

namespace tex

{
		


public class filtro:leer
		{
	
	
		
public filtro

// metodo que limita  la cantidad de byte que puede tener un archiv
		
      public string filtrarbyte(){
// guardar los bytes del archivo
			
			
          
			byte[] bytes = new byte[200];

    // leer los primeros bytes del archivo limite
    lectura().Read(bytes, 0, 100);
	
			Console.WriteLine(Encoding.ASCII.GetString(bytes));	
		}
		
		}
	}


