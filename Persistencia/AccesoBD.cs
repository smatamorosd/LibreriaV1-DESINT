﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;

namespace LibreriaV5_Final.Persistencia
{
    public abstract class AccesoBD
    {
        private static MySqlConnection connection = null;
        private MySqlTransaction transaccion;
        private MySqlCommand comando;

        public AccesoBD()
        {
            try
            {
                connection = ConexionJDBC.AbrirConexion();
            }
            catch (Exception e)
            {
                throw;
                //throw new Exception(e.Message, e);
            }
        }


        public bool EjecutarUpdate(string sql, object objeto)
        {
            try
            {
                StartTransaction();
                //"SELECT * FROM admin WHERE admin_username=@val1 AND admin_password=PASSWORD(@val2)"
                comando = new MySqlCommand(sql, connection); ///Esto es como preparedStatement
                PropertyInfo[] propertyInfo = objeto.GetType().GetProperties();
                int index = 1;

                if (sql.Contains("DELETE"))
                {
                    comando.Parameters.AddWithValue("@1", propertyInfo[0].GetValue(objeto));
                }
                else
                {
                    for (int i = 0; i < propertyInfo.Length; i++)
                    {
                        comando.Parameters.AddWithValue("@" + index++, propertyInfo[i].GetValue(objeto));
                    }
                    if (sql.Contains("UPDATE"))
                    {
                        comando.Parameters.AddWithValue("@" + index, propertyInfo[0].GetValue(objeto));
                    }
                }
                Commit();
            }
            catch (Exception) { RollBack(); throw; }
            return comando.ExecuteNonQuery() > 0;
        }

        public List<object> EjecutarConsulta(string sql, Type clase, string nombre)
        {
            List<object> objetos = null;
            MySqlDataReader sqlDataReader = null;
            try
            {
                comando = new MySqlCommand(sql, connection);
                if (!nombre.Equals(""))
                {
                    comando.Parameters.AddWithValue("@a1", nombre);
                }
                sqlDataReader = comando.ExecuteReader();
                if (sqlDataReader != null)
                {
                    objetos = new List<object>();
                    PropertyInfo[] list = UtilSQL.ObtenerNombrePropiedades(clase);
                    {
                        while (sqlDataReader.Read())
                        {
                            object obj = Activator.CreateInstance(clase);
                            foreach (PropertyInfo name in list)
                            {
                                string valor = (String)sqlDataReader[name.Name].ToString();
                                name.SetValue(obj, Convert.ChangeType(valor, name.PropertyType), null);

                            }
                            objetos.Add(obj);
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlDataReader.Close();
            }
            return objetos;
        }

        public void StartTransaction()
        {
            transaccion = connection.BeginTransaction();
        }

        public void RollBack()
        {
            transaccion.Rollback();
        }

        public void Commit()
        {
            transaccion.Commit();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public string ObtenerCodigo(Type clase)
        {
            string sql = "SELECT MAX(Cod" + clase.Name.Substring(1) + ") FROM " + clase.Name.ToLower();
            MySqlDataReader sqlDataReader = null;
            try
            {
                comando = new MySqlCommand(sql, connection);
                sqlDataReader = comando.ExecuteReader();
                sqlDataReader.Read();
                return sqlDataReader[0].ToString();
            }
            catch (Exception) { throw; }
            finally
            {
                sqlDataReader.Close();
            }
        }

        /**
         * INNER CLASS... 
         **/

        public class ConexionJDBC
        {
            private static MySqlConnection connection;

            /*  
             *  Abre la conexion con la base de datos
             */
            public static MySqlConnection AbrirConexion()
            {
                if (connection == null)
                {
                    try
                    {
                        connection = new MySqlConnection();
                        connection.ConnectionString =
                            "Server=" + ConfigurationManager.AppSettings["servidor"].ToString()
                            + ";Database=" + ConfigurationManager.AppSettings["baseDatos"].ToString()
                            + ";Uid=" + ConfigurationManager.AppSettings["usuario"].ToString()
                            + ";Pwd=" + ConfigurationManager.AppSettings["password"].ToString() + ";";
                        connection.Open();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                return connection;
            }

            public static void CerrarConexion()
            {
                if (connection != null) connection.Close();

            }
        }

    }
}
