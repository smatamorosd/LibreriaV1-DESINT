using LibreriaV3._1.Modelo;
using System;

public class Estanteria
{   	   
    //Propiedades
    //Limite de registros en el array
    const int max_Reg = 5;
    //Array normal con objetos Libro dentro y un valor maximo de la variable max_reg
    Libro[] libros = new Libro[max_Reg];
    //Reg es el contador de registros, que nos sirve para saber la cantidad de libros almacenados
    private int reg = 0;


    //Codigos de estado de la estanteria
    public const int INTRODUCIDO = 1;
    public const int LIBRO_EXISTE = -1;
    public const int ESTANTERIA_LLENA = 0;

    //Variable que uso, para moverme entre el array, y no crearla a nivel local de m�todo

    /// <summary>
    ///  <para>
    ///        Introducimos por parametros un libro previamente creado.
    ///  </para>
    ///    
    ///  <para>
    ///        Comprobamos que no exista o que el array no esté lleno y si se cumple todo lo introducimos
    ///  </para>
    /// 
    /// </summary>
    /// <param name="libro">Admite parámetro del tipo Libro</param>
    /// <returns>
    /// Devolvera valores de : 1 en caso de libro introducido <br />
    ///       -1 en caso de que el libro ya exista<br/>
    ///       0 en caso de que el array este lleno
    /// </returns>
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
        if (posicionLibro != -1)
        {
            for (int i = posicionLibro; i < libros.Length - 1; i++)
            {
                libros[i] = libros[i + 1];
            }
        }
        libros[libros.Length - 1] = null;
    }//borrarLibro



    /// <summary>
    ///     Introduce un nombre de un libro por parametros y lo busca
    /// </summary>
    /// <param name="nombre"></param>
    /// <returns>La posición del libro, en caso de que esté, o -1 si no está</returns>
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


}
