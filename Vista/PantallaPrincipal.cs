using LibreriaV3._1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/**
 * Errores encontrados:
 * Algunas veces al borrar el texto y darle click a la lista de libros, devolvera un no encontrado.
 * Al modificar un libro devuelve no encontrado, pero lo modifica igual.
 * 
 * -------
 * Poner un lst mal para que de un error al modificar libro...
 * 
 * 
*/

namespace LibreriaV3._1
{
    public partial class PantallaPrincipal : Form
    {
        private Estanteria acceso = new Estanteria();

        public PantallaPrincipal()
        {
              InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se han introducido estas líneas para comprobar como el evento Load
            // es lo primero que se carga en el arranque de la aplicación.
            // Es conveniente poner un punto de ruptura en la clase Program para ver cómo 
            // arranca la aplicación y los métodos por los que pasa, en nuestro caso por el constructor
            // PantallaPrincipal()

            //Añadimos los temas
            cbxTemas.Items.Add("Acción");
            cbxTemas.Items.Add("Informatica");
            cbxTemas.Items.Add("Aventura");
            cbxTemas.Items.Add("Romantica");
            cbxTemas.Items.Add("Tupidora");
            cbxTemas.Items.Add("Ficción");
            cbxTemas.Items.Add("Acción");

            //Cargamos los libros del fichero
            List<Libro> libros = acceso.cargarLibros();

            //Recorremos la lista y lo añadimos al ListBox
            foreach(Libro libro in libros)
            {
                lstLibros.Items.Add(libro);
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            VaciarPantalla();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Libro datosPantalla = RecogerDatosPantalla();

            if (datosPantalla == null) return;

            bool estado = acceso.insertarLibro(datosPantalla);

            if (!estado)
            {
                MostrarMensaje(Mensajes.MSG_YAEXISTE);
                return;
            }

            lstLibros.Items.Add(txtTitulo.Text);
            MostrarMensaje(Mensajes.MSG_INSERTADO);
            VaciarPantalla();
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LstLibros_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedItem != null)
            {
                EnviarDatosAPantalla(acceso.buscarLibro(lstLibros.SelectedItem.ToString()));
            }
                    
        }
           
        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if(lstLibros.SelectedItem != null) 
            {
                acceso.borrarLibro(acceso.buscarLibro(lstLibros.SelectedItem.ToString()));

                //lstLibros.Items.Remove(lstLibros.SelectedIndex); 

                lstLibros.Items.RemoveAt(lstLibros.SelectedIndex);


                VaciarPantalla();              
            }
        }
        
        private void TxtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        
        private void BtnModificar_Click(object sender, EventArgs e)
        {
        //* Si estado es -1 indica que el libro no se ha encontrado.
        //* Cualquier otro valor devuelto, indicará que el libro se ha encontrado y la insercción ha sido correcta.
            if (lstLibros.SelectedItem != null)
            {
                String lstSelectedItem = lstLibros.SelectedItem.ToString();

                //Mandamos el nombre del libro seleccionado y recogemos
                //los cambios que se han hecho en los inputs...
                bool estado = acceso.modificarLibro(
                    lstSelectedItem,
                    RecogerDatosPantalla()
                );

                if (!estado)
                {
                    MostrarMensaje(Mensajes.MSG_NO_ENCONTRADO);
                    return;
                }

                //Actualizamos el lst....
                //lstLibros.Items.Remove(lstSelectedItem);
                lstLibros.Items.RemoveAt(lstLibros.SelectedIndex);
                lstLibros.Items.Add(txtTitulo.Text);

                //lstLibros.SetSelected(lstLibros.SelectedIndex - 1, true);

                MostrarMensaje(Mensajes.MSG_MODIFICADO);
            }

        }
        //*****************************  MÉTODOS  PRIVADOS INTERNOS DE LA CLASE  ******************

        /******************************************************************************************
         * Metodo para recoger los datos
         * Se encarga de montar un libro a través de los datos que introduces en la ventana gráfica
         ******************************************************************************************/

        private Libro RecogerDatosPantalla()
        {
            String titulo, autor, paginas, precio, formatoUno, formatoDos, formatoTres, estado, tema;
            titulo = txtTitulo.Text;
            autor = txtAutor.Text;
            paginas = txtPaginas.Text;
            precio = txtPrecio.Text.Replace(".", ",");
            precio = precio.Replace("€", "");
            precio = precio.Trim();
            formatoUno = chkCartone.Checked ? chkCartone.Text : "N/A";
            formatoDos = chkRustica.Checked ? chkRustica.Text : "N/A";
            formatoTres = chkTapaDura.Checked ? chkTapaDura.Text : "N/A";

            tema = cbxTemas.SelectedItem == null
                ? "N/A"
                : cbxTemas.SelectedItem.ToString();

            if (rbNovedad.Checked)
            {
                estado = "novedad";
            }
            else
            {
                estado = "reedicion";
            }

            //Comprobaciones
            if (titulo == "")
            {
                MostrarMensaje(Mensajes.MSG_ERRCAMPO_Titulo);
                return null;
            }

            /*if (!chkCartone.Checked && !chkRustica.Checked && !chkTapaDura.Checked)
            {
                MostrarMensaje("Es necesario rellenar el formato");
                return null;
            }*/

            if (autor == "" || paginas.Length == 0 || precio.Length == 0)
            {
                MostrarMensaje(Mensajes.MSG_ERRCAMPOS_VACIO);
                return null;
            }

            return new Libro(autor, titulo, tema, paginas, precio, formatoUno, formatoDos, formatoTres, estado);
        }

        /*********************************************************************************************
	     * Pasamos por parametro un libro y este método se encargará de mostrarnos en la parte gráfica
	     * todo el contenido del libro.
	     *********************************************************************************************/
        private void EnviarDatosAPantalla(Libro libro)
        {
            txtAutor.Text = libro.Autor;
            txtPaginas.Text = libro.Paginas;
            txtPrecio.Text = libro.Precio + " €";
            txtTitulo.Text = libro.Titulo;
            cbxTemas.Text = libro.Tema;
            if (libro.Estado.Equals("reedicion"))
            {
                rbReedicion.Checked = true;
                rbNovedad.Checked = false;
            }
            else
            {
                rbNovedad.Checked = true;
                rbReedicion.Checked = false;
            }

            chkCartone.Checked = libro.Formatouno.Equals("Cartoné") ? true : false;
            chkRustica.Checked = libro.Formatodos.Equals("Rústica") ? true : false;
            chkTapaDura.Checked = libro.Formatotres.Equals("Tapa dura") ? true : false;
        }

        /*************************************************************************************
         * Método encargado de limpiar los campos de la pantalla
         * ***********************************************************************************/

        private void VaciarPantalla()
        {
            txtAutor.Text = "";
            txtMensaje.Text = "";
            txtPaginas.Text = "";
            txtPrecio.Text = "";
            txtTitulo.Text = "";
            rbReedicion.Checked = false;
            chkCartone.Checked = false;
            chkRustica.Checked = false;
            chkTapaDura.Checked = false;
            cbxTemas.SelectedIndex = -1; //Borramos el texto del tema...
        }
        private void MostrarMensaje(string mensaje)
        {
            txtMensaje.Text = mensaje;
            MessageBox.Show(mensaje);
        }
    }
}
