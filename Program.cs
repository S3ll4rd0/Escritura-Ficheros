using System;
using System.IO;

public class champions
{
    public static void Main (string [] args)
    {
        StreamReader sr;
        string nombre;
        string himno = "open";
        string linea;
        while (true)
        {
            Console.WriteLine("Introduzca el nombre del fichero para buscarlo.");
            Console.WriteLine("O en su defecto introduzca \"fin\" para terminar");
            nombre = Console.ReadLine();

            if (nombre == "fin")
            {
                break;
            }

            if (File.Exists(nombre))
            {
                sr = File.OpenText(nombre);
                Console.WriteLine("Himno Añadido");
                Console.WriteLine("Su himno es el siguiente:");
                do
                {
                    linea = sr.ReadLine();
                    if (linea != null) ;
                    Console.WriteLine(linea);
                }
                while (linea != null);
                sr.Close();
            }
            else
            { 
                Console.WriteLine("El fichero mencionado no existe,\nva a ser creado en este momento");
                StreamWriter sw = new StreamWriter(nombre);
                Console.WriteLine("Introduzca a continuación el himno de su equipo favorito frase a frase");
                Console.WriteLine("Cuando termine de introducir el himno escriba \"close\" para continuar");

                while (true)
                {
                    if (himno == "close")
                    {
                        sw.Close();
                        break;
                    }
                    else
                    {
                        himno = Console.ReadLine();
                        sw.WriteLine(himno);
                    }
                }
            }
        }
    }
}