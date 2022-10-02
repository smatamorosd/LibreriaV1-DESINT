using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_V3.Modelo
{
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
        //crear fichero
        private FileStream fileStream = null;

        //------------------------------METODOS 
        /**
        * Inserta un libro en un arrayList
        * @param obLibro
        * @return True/False
        */
        public Estanteria()
        {

        }
        public List<Libro> CargarLibros()
        {
            libros = LeerFichero();

            return libros;
        }
        public Boolean InsertarLibro(Libro oblibro)
        {
            if (BuscarLibro(oblibro.Titulo) == null)
            {
                libros.Add((oblibro));
                EscribirFichero(libros);
                return true;
            }

            return false;
        }//insertarLibro

        /**
        * Modifica un libro en el ArrayList. Primero se localiza y si se encuentra se borra y añade uno nuevo
        * con los datos procedentes del objeto.
        */
        public Boolean ModificarLibro(Libro oblibro)
        {
            Boolean modificado = false;
            Libro libro = BuscarLibro(oblibro.Titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                libros.Add((oblibro));
                EscribirFichero(libros);
                modificado = true;
            }
            return modificado;
        }//modificarLibro

        /**
         * Entra por parametros el objeto libro devuelve dicho objeto si es encontrado en el arrayList
         * que fue cargado desde un fichero.
         * @param nombre
         * @return
         */
        public Libro BuscarLibro(String nombre)
        {
                foreach (var oblibro in libros)
                {
                    if (oblibro.Titulo.Equals(nombre))
                    {
                        return oblibro;
                    }

                }//foreach
                return null;
        }//buscarLibro

        /**
         * Borra un libro del arrayList a través del nombre
         * @param nombre
         * @return True/False
         */
        public Boolean BorrarLibro(Libro oblibro)
        {
            Libro libro = BuscarLibro(oblibro.Titulo);
            if (libro != null)
            {
                libros.Remove(BuscarLibro(oblibro.Titulo));
                EscribirFichero(libros);
                return true;
            }
            return false;
        }//borrarLibro*/

        //*************************   Métodos PRIMITIVOS de FICHEROS  ***************************************************

        public List<Libro> LeerFichero()
        {
         
            fileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);

            try
            {
                formatter = new BinaryFormatter();
                if (File.Exists(DATA_FILENAME))
                {
                    var info = new FileInfo(DATA_FILENAME);
                    if (info.Length > 0)
                    {
                        libros = (List<Libro>)formatter.Deserialize(fileStream);
                    }
                  
                }
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Error al deserializar el fichero:" + e.Message);
                throw;
            }
            finally
            {
                CerrarFichero();
            }
            return libros;
        }
        private void EscribirFichero(List<Libro> libros)
        {
            try
            {
                 IFormatter formatter = new BinaryFormatter();
                 using (Stream stream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(stream, libros);
                }
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Error al serializar el fichero:" + e.Message);
                throw;
            }
            finally
            {
                CerrarFichero();
            }
        }
        private void CerrarFichero()
        {
            try
            {
                fileStream.Close();
                fileStream.Dispose();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
