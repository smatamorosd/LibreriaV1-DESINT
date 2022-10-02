using LibreriaV3._1.Modelo;
using System;
using System.Collections.Generic;

public class EstanteriaOld
{


    //ArrayList donde se almacena cada LIBRO
    private List<Libro> libros = new List<Libro>();

    //------------------------------METODOS 
    /**
	* Inserta un libro en un arrayList
	* @param obLibro
	* @return True/False
	*/
    public Boolean insertarLibro(Libro libro)
    {
        if (buscarLibro(libro.Titulo) == null)
        {
            libros.Add(libro);
            return true;
        }
        return false;
    }

    /**
    * Modifica un libro en el ArrayList. Primero se localiza y si se encuentra se borra y añade uno nuevo
    * con los datos procedentes del objeto.
    */
    public Boolean modificarLibro(String actualTitle, Libro libroModificar)
    {
        Libro libro = buscarLibro(actualTitle);
        if (libro != null)
        {
            libros.Remove(libro);
            libros.Add(libroModificar);
            return true;
        }
        return false;
    }

    /**
	 * Entra por parametros una String con un titulo, y te devuelve el objeto libro exacto
	 * @param nombre
	 * @return
	 */
    public Libro buscarLibro(String titulo)
    {
        foreach (var libro in libros)
        {
            if (libro.Titulo.Equals(titulo))
            {
                return libro;
            }

        }
        return null;
    }

    /**
     * Borra un libro del arrayList a través del nombre
     * @param nombre
     * @return True/False
     */
    public Boolean borrarLibro(String titulo)
    {
        Libro libro = buscarLibro(titulo);
        if (libro != null)
        {
            libros.Remove(libro);
            return true;
        }
        return false;
    }
}