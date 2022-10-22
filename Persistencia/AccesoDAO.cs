﻿using LibreriaV5_Final.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LibreriaV5_Final.Persistencia
{
    public class AccesoDAO<T> : AccesoBD, IAcceso<T> where T : new()
    {
        public bool BorradoVirtual(object objeto)
        {
            bool borrado = false;
            string sql;
            // Ver si se puede mejorar sin necesidad de recorrer todas las propiedades del objeto
            // Tener en cuenta, que el campo con el nombre Borrado lo tendrán todas las tablas.
            PropertyInfo[] props = UtilSQL.ObtenerNombrePropiedades(objeto.GetType());

            //Nos situamos en la ultima posición del array
            props[props.Length -1].SetValue(objeto, "1");

            /*foreach (var item in objeto.GetType().GetProperties())
            {
                if (item.Name.Contains("Borra"))
                {
                    item.SetValue(objeto, "1");
                }
            }*/

            try
            {
                if ((sql = UtilFichero.ExisteSentencia("BORRADOVIRTUAL" + objeto.GetType().Name)) == null)
                {
                    if (EjecutarUpdate(UtilFichero.GuardarSQL("BORRADOVIRTUAL" + objeto.GetType().Name, UtilSQL.SqlModificar(objeto)), objeto))
                    {
                        borrado = true;
                    }
                }
                else
                {
                    if (EjecutarUpdate(sql, objeto))
                    {
                        borrado = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return borrado;
        }

        public bool Borrar(object objeto)
        {
            bool borrado = false;

            string sql;
            try
            {
                if ((sql = UtilFichero.ExisteSentencia("DELETE" + objeto.GetType().Name)) == null)
                {
                    if (EjecutarUpdate(UtilFichero.GuardarSQL("DELETE" + objeto.GetType().Name, UtilSQL.SqlBorrar(objeto)), objeto))
                    {
                        borrado = true;
                    }
                }
                else
                {
                    if (EjecutarUpdate(sql, objeto))
                    {
                        borrado = true;
                    }
                }
            } catch (Exception) { throw; }


            return borrado;
        }
        //
        public object BuscarOne(Type clase, string nombre)
        {
            List<object> list = null;
            Object obj=null;
            String sql;
            try
            {
                // Si la orden SQL no existe se guarda en un Dictionary, que al terminar
                // el programa guardará todas las órdenes en el fichero sql.txt
                if ((sql = UtilFichero.ExisteSentencia("SELECTONE" + clase.Name)) == null)
                {
                    //De esta forma se puede ver mejor la construcción de la orden SQL.
                    sql = UtilFichero.GuardarSQL("SELECTONE" + clase.Name, UtilSQL.SqlBuscar(clase));    
                }
                //if ((list = EjecutarConsulta(sql, clase, nombre)).Count != 0)
                if ((list=EjecutarConsulta(sql, clase, nombre)).Count != 0)
                    {
                     obj = list.First();
                    }                
            }
            catch (Exception) { throw; }
            return obj;
        }
        //
        /*public object Buscar(Type clase, string nombre)
        {
            List<object> list = null;
            Object obj = null;

            String sql;
            if ((sql = UtilFichero.ExisteSentencia("SELECTONE" + clase.Name)) == null)
            {
                try
                {
                    //De esta forma se puede ver mejor la construcción de la orden SQL.
                    //sql=UtilFichero.GuardarSQL("SELECTONE" + clase.Name, UtilSQL.SqlBuscar(clase))
                    //if ((list = EjecutarConsulta(sql, clase, nombre)).Count != 0)
                    if ((list = EjecutarConsulta(UtilFichero.GuardarSQL("SELECTONE" + clase.Name, UtilSQL.SqlBuscar(clase)), clase, nombre)).Count != 0)
                    {
                        obj = list.First();
                    }
                }
                catch (Exception) { throw; }
            }
            else
            {
                try
                {
                    if ((list = EjecutarConsulta(sql, clase, nombre)).Count != 0)
                    {
                        obj = list.First();
                    }
                }
                catch (Exception) { throw; }
            }
            return obj;
        }*/

        public List<object> Buscar(Type clase, string campo, string busqueda)
        {
            String sql = "SELECT * FROM " + clase.Name + " WHERE " + campo + " = \"" + busqueda + "\"";
            try
            {
                return EjecutarConsulta(sql, clase, "");
            }
            catch (Exception) { throw; }
        }

        public bool Insertar(T objeto)
        {
            bool insertado = false;

            string sql;

            try
            {
                //Si no existe el archivo de "CACHÉ"...
                if ((sql = UtilFichero.ExisteSentencia("INSERTAR" + objeto.GetType().Name)) == null)
                {
                    if (EjecutarUpdate(UtilFichero.GuardarSQL("INSERTAR" + objeto.GetType().Name, UtilSQL.SqlInsertar(objeto)), objeto))
                    {
                        insertado = true;
                    }
                    return insertado;
                }

                if (EjecutarUpdate(sql, objeto))
                {
                    insertado = true;
                }

            } catch (Exception) { throw; }
            
            return insertado;
        }
  
        public bool Modificar(T objeto)
        {
            bool modificado = false;
            string sql;
            Console.WriteLine("Nombre de la clase del objeto: " + objeto.GetType().Name);

            try
            {
                //Si no existe la "CACHÉ"...
                if ((sql = UtilFichero.ExisteSentencia("UPDATE" + objeto.GetType().Name)) == null)
                {
                    if (EjecutarUpdate(UtilFichero.GuardarSQL("UPDATE" + objeto.GetType().Name, UtilSQL.SqlModificar(objeto)), objeto))
                    {
                        modificado = true;
                    }

                    return modificado;
                }

                //Si existe una caché, la recogemos y la ejecutamos...
                if (EjecutarUpdate(sql, objeto))
                {
                    modificado = true;
                }
            } catch (Exception) { throw; }

            return modificado;
        }

        public List<Object> BuscarAll(Type clase)
        {
            List<Object> obj = null;
            string sql;
            try
            {
                if ((sql = UtilFichero.ExisteSentencia("SELECTALL" + clase.Name)) == null)
                {
                    obj = EjecutarConsulta(UtilFichero.GuardarSQL("SELECTALL" + clase.Name, UtilSQL.SqlObtener(clase)), clase, "");
                }

                else
                {
                    obj = EjecutarConsulta(sql, clase, "");
                }
            }
            catch (Exception)
            {

                throw;
            }

            return obj;

        }
    }
}
