using LibreriaV3._1.Modelo;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System;

public class Estanteria
{


    //ArrayList donde se almacena cada LIBRO 
    //---IMPORTANTE- Se ha optado por utilizar el array de libros para manejar ficheros binarios,
    // esto hace que la gestión sea más sencilla. No sería la mejor manera de gestionar los ficheros 
    // si tuviésemos un gran número de registros. Al hacerlo de esta manera, estamos optando por una gestión 
    // híbrida de los ficheros, utilizando un array de objetos como intermediario con el fichero.
    // El fichero data.dat  se encuentra en la dirección  E:\~LibreriaV3\LibreriaV1\bin\Debug

    private List<Libro> libros = new List<Libro>();

    //--------------------------------------------------------------------------------------------------------
    private const string DATA_FILENAME = "data.dat";
    private BinaryFormatter formatter;
    private FileStream readerFileStream = null;

    //------------------------------METODOS 
   
    //Leer todas las filas del fichero y cargarlas en la lista
    public List<Libro> cargarLibros()
    {
        List<Libro> libros = leerFichero();

        return libros;
    }

    /**
       * Inserta un libro en un arrayList
       * @param obLibro
       * @return True/False
   */
    public Boolean insertarLibro(Libro oblibro)
    {
        if (buscarLibro(oblibro.Titulo) == null)
        {
            //Añadimos el libro al arraylist 
            libros.Add(oblibro);

            //Añadimos el registro del libro al fichero
            escribirFichero(libros);
            return true;
        }
        return false;
    }//insertarLibro

    /**
    * Modifica un libro en el ArrayList. Primero se localiza y si se encuentra se borra y añade uno nuevo
    * con los datos procedentes del objeto.
    */
    public Boolean modificarLibro(Libro oblibro)
    {
        Libro libro = buscarLibro(oblibro.Titulo);
        if (libro != null)
        {
            libros.Remove(libro);
            libros.Add(oblibro);

            //Reescribimos el fichero 
            escribirFichero(libros);

            return true;
        }
        return false;
    }//modificarLibro

    /**
	 * Entra por parametros el objeto libro devuelve dicho objeto si es encontrado en el arrayList
     * que fue cargado desde un fichero.
	 * @param nombre
	 * @return
	 */
    public Libro buscarLibro(String nombre)
    {
        foreach (var oblibro in libros)
        {
            if (oblibro.Titulo.Equals(nombre))
            {
                return oblibro;
            }

        }
        return null;
    }

    /**
     * Borra un libro del arrayList a través del nombre
     * @param nombre
     * @return True/False
     */
    public Boolean borrarLibro(Libro oblibro)
    {
        Boolean borrado = false;
        Libro libro = buscarLibro(oblibro.Titulo);
        if (libro != null)
        {
            libros.Remove(buscarLibro(oblibro.Titulo));
            escribirFichero(libros);
            borrado = true;
        }
        return borrado;
    }//borrarLibro*/

    //*************************   Métodos PRIMITIVOS de FICHEROS  ***************************************************

    public List<Libro> leerFichero()
    {
        formatter = new BinaryFormatter();
        try
        {
            if (File.Exists(DATA_FILENAME))
            {
                readerFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                readerFileStream.Position = 0;
                libros = (List<Libro>)formatter.Deserialize(readerFileStream);
            } else {

                //Creamos el fichero 
                readerFileStream = new FileStream(DATA_FILENAME, FileMode.CreateNew, FileAccess.Write);

            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Error fichero:" + e.Message);
        }
        finally
        {
            cerrarFichero();
        }
        return libros;
    }

    /// <summary>
    /// Escribe un fichero de cero
    /// </summary>
    /// <param name="libros"></param>
    private void escribirFichero(List<Libro> libros)
    {
        formatter = new BinaryFormatter();
        try
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(
                DATA_FILENAME, FileMode.Create, FileAccess.Write, FileShare.None)
            )
            {

                formatter.Serialize(stream, libros);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Error fichero:" + e.Message);
        }
        finally
        {
            cerrarFichero();
        }
    }
    private void cerrarFichero()
    {
        //readerFileStream.Flush();
        readerFileStream.Close();
        readerFileStream.Dispose();
    }
}//class