using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_V1.Modelo
{
    public class Estanteria
    {
        //Propiedades
        //Limite de registros en el array
        const int MAX_REG = 5;
        //Codigos de estado de la estanteria
        public const int INTRODUCIDO = 1;
        public const int LIBRO_EXISTE = -1;
        public const int ESTANTERIA_LLENA = 0;
        //Array normal con objetos Libro dentro y un valor maximo de la variable max_reg
        private readonly Libro[] libros = new Libro[MAX_REG];


        public int InsertarLibro(Libro libro)
        {
            int posicionLibro = PosicionLibro(libro.Titulo);
            if (posicionLibro != -1)
            {
                return LIBRO_EXISTE;
            }
            for (int i = 0; i < libros.Length; i++)
            {
                if (libros[i] == null)
                {
                    libros[i] = libro;
                    return INTRODUCIDO;
                }
            }
            return ESTANTERIA_LLENA;

        }//insertarLibro

        /**
      * Introduce un titulo de un libro por parametros y busca su posicion
      * @param nombre
      * @return La posici�n del libro, en caso de que est�, o -1 si no est�
      */
        private int PosicionLibro(String titulo)
        {
            for (int i = 0; i < libros.Length; i++)
            {
                if (libros[i] != null && libros[i].Titulo.Equals(titulo))
                {
                    return i;
                }
            }
            return -1;
        }//posicionLibro



        /**
        * Introducimos por parametros un libro previamente creado.
        * Comprobamos que no exista o que el array no est� lleno y si se cumple todo lo introducimos
        * @param libro
        * @return Devolvera valores de : 1 en caso de libro introducido
        * 	    						 -1 en caso de que el libro ya exista
        * 								  0 en caso de que el array este lleno
        */
        public int ModificarLibro(Libro libro)
        {
            int posicionLibro = PosicionLibro(libro.Titulo);
            //
            if (posicionLibro != -1)
            {
                libros[posicionLibro] = libro;
            }
            return posicionLibro;
        }//modificarLibro


        /**
         * Entra por parametros una String con un titulo, y te devuelve el objeto libro exacto
         * @param nombre
         * @return
         */
        public Libro BuscarLibro(String titulo)
        {
            int posicionLibro = PosicionLibro(titulo);
            if (posicionLibro != -1)
            {
                return libros[posicionLibro];
            }
            return null;
        }//buscarLibro


        public void BorrarLibro(String titulo)
        {
            int posicionLibro = PosicionLibro(titulo);
            //La posicion del libro, en caso de que estaa, o -1 si no esta
            //o sea que se ha encontrado el libro
            if (posicionLibro != -1)
            {
                for (int i = posicionLibro; i < libros.Length - 1; i++)
                {
                    libros[i] = libros[i + 1];
                }
            }
            libros[libros.Length - 1] = null;
        }//borrarLibro
    }
}
