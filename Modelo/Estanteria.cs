using System;
using System.Collections.Generic;


namespace Libreria_V2_Casa.Modelo.Estanteria { 
    public class Estanteria
    {
        //Propiedades

        //ArrayList donde se almacena cada LIBRO
        private List<Libro> libros = new List<Libro>();

        /**
            * Inserta un libro en un arrayList
            * @param obLibro
            * @return True/False
            */
        public Boolean InsertarLibro(Libro libro)
        {
            if (BuscarLibro(libro.Titulo) == null)
            {
                libros.Add((libro));
                return true;
            }//if
            else
                return false;

        }//insertarLibro

        /**
        * Modifica un libro en el ArrayList. Primero se localiza y si se encuentra se borra y añade uno nuevo
        * con los datos procedentes del objeto.
        */
        public Boolean ModificarLibro(Libro libro)
        {
            Boolean modificado = false;
            Libro libroAux = BuscarLibro(libro.Titulo);
            if (libro != libroAux)
            {
                libros.Remove(libroAux);
                libros.Add(libro);
                modificado = true;
            }
            return modificado;
        }//modificarLibro


        /**
         * Entra por parametros una String con un titulo, y te devuelve el objeto libro exacto
         * @param nombre
         * @return
         */
        public Libro BuscarLibro(String titulo)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo.Equals(titulo))
                {
                    return libro;
                }

            }//foreach
            return null;
        }//buscarLibro



        /**
         * Borra un libro del arrayList a través del nombre
         * @param nombre
         * @return True/False
         */
        public Boolean BorrarLibro(String titulo)
        {
            Boolean borrado = false;
            if (libros.Count != 0)
            {
                foreach (var l in libros)
                {
                    if (l.Titulo.Equals(titulo))
                    {
                        libros.Remove(l);
                        borrado = true;
                    }
                    break;
                }

            }
            return borrado;
        }//borrarLibro
    }

}
