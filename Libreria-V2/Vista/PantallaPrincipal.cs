using Libreria_V2.Modelo;
using Libreria_V2.Resources;


namespace Libreria_V2
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        Estanteria acceso = new Estanteria();

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Libro datosPantalla = RecogerDatosPantalla();

            if (datosPantalla == null) return;
            if (acceso.InsertarLibro(datosPantalla))
            {
                lstLibros.Items.Add(txtTitulo.Text);
                MostrarMensaje(Mensajes.MSG_INSERTADO);
            }
            else { 
                MostrarMensaje(Mensajes.MSG_YAEXISTE);
            }
            VaciarPantalla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            VaciarPantalla();
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedItem != null)
            {
                acceso.BorrarLibro(lstLibros.SelectedIndex);
                lstLibros.Items.Remove(lstLibros.SelectedItem.ToString());
                VaciarPantalla();
            }
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedItem != null)
            {
                if (acceso.ModificarLibro(RecogerDatosPantalla()))
                {
                    MostrarMensaje(Mensajes.MSG_MODIFICADO);
                }
                else
                {
                    MostrarMensaje(Mensajes.MSG_NO_CAMBIOS);
                }
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

        private void LstLibros_Click(object sender, EventArgs e)
        {
            txtTitulo.Enabled = false;
            if (lstLibros.SelectedItems.Count != 0)
            {
                EnviarDatosAPantalla(acceso.BuscarLibro(lstLibros.SelectedItem.ToString()));
            }
            
            
        }
    
        private void RdbNovedad_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RdbReedicion_CheckedChanged(object sender, EventArgs e)
        {
        }


        //*****************************  MÉTODOS  PRIVADOS INTERNOS DE LA CLASE  ******************

        /******************************************************************************************
         * Metodo para recoger los datos
         * Se encarga de montar un libro a través de los datos que introduces en la ventana gráfica
         ******************************************************************************************/

        private Libro RecogerDatosPantalla()
        {

            string titulo, autor, paginas, precio, formatoUno, formatoDos, formatoTres, estado, tema;
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
                MostrarMensaje(Mensajes.MSG_CAMPOSVACIOS);
                return null;
            }

            if (!chkCartone.Checked && !chkRustica.Checked && !chkTapaDura.Checked)
            {
                MostrarMensaje(Mensajes.MSG_CAMPOSVACIOS);
                return null;
            }

            if (autor == "" || paginas.Length == 0 || precio.Length == 0)
            {
                MostrarMensaje(Mensajes.MSG_CAMPOSVACIOS);
                return null;
            }

            Libro libro = new Libro(autor, titulo, tema, paginas, precio, formatoUno, formatoDos, formatoTres, estado);

            return libro;
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
            chkTapaDura.Checked = libro.Formatotres.Equals("Tapa Dura") ? true : false;
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

        private void txtPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}