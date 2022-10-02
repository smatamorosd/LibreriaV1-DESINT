using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_V2.Modelo
{
    public class Estanteria
    {
        //ArrayList donde se almacena cada LIBRO
        private readonly List<Libro> libros = new();

        //------------------------------METODOS 
        /**
        * Inserta un libro en un arrayList
        * @param obLibro
        * @return True/False
        */
        public Boolean InsertarLibro(Libro libro)
        {
            if (BuscarLibro==null)
            {
                libros.Add((libro));
                return true;
             
            }
            return false;
        }//insertarLibro


        public Boolean ModificarLibro(Libro libroNuevo)
       { 
            Libro LibroAmodificar=BuscarLibro(libroNuevo.Titulo);
            if (!LibroAmodificar.Equals(libroNuevo)){
                LibroAmodificar.Autor = libroNuevo.Autor;
                LibroAmodificar.Tema = libroNuevo.Tema;
                LibroAmodificar.Paginas = libroNuevo.Paginas;
                LibroAmodificar.Precio = libroNuevo.Precio;
                LibroAmodificar.Formatouno = libroNuevo.Formatouno;
                LibroAmodificar.Formatodos = libroNuevo.Formatodos;
                LibroAmodificar.Formatotres = libroNuevo.Formatotres;
                return true;
            }
            return false;

        }//modificarLibro

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
         * Borra un libro del arrayList a través del indice pasado
         * @param index del libro
         */
        public Boolean BorrarLibro(int index)
        {
            if (libros.Count != 0)
            {
                libros.Remove(libros[index]);
                return true;
            }
           return false;
        }//borrarLibro

    }
}
