using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Libreria_V1.Modelo;


namespace Libreria_V1
{
    public partial class PantallaPrincipal : Form
    {
        private Estanteria acceso = new Estanteria();
        public PantallaPrincipal()
        {
            InitializeComponent();
        }


        private void Form_Load(object sender, EventArgs e)
        {
            cbxTemas.Items.Add("Acción");
            cbxTemas.Items.Add("Informática");
            cbxTemas.Items.Add("Aventura");
            cbxTemas.Items.Add("Romántica");
            cbxTemas.Items.Add("Ficción");
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            int estado = 0;
            estado = acceso.InsertarLibro(RecogerDatosPantalla());
            if (estado == Estanteria.INTRODUCIDO)
            {
                lstLibros.Items.Add(txtTitulo.Text);
                MostrarMensaje("Libro Creado Correctamente");
            }
            else if (estado == Estanteria.LIBRO_EXISTE)
            {
                MostrarMensaje("El libro ya existe");
            }
            else if (estado == Estanteria.ESTANTERIA_LLENA)
            {
                MostrarMensaje("No hay espacio para mas libros");
            }
            VaciarPantalla();

        }

        private void MostrarMensaje(string mensaje)
        {
            txtMensaje.Text = mensaje;
            MessageBox.Show(mensaje);
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            acceso.BorrarLibro(lstLibros.SelectedItem.ToString());
            lstLibros.Items.Remove(lstLibros.SelectedItem.ToString());
            VaciarPantalla();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            VaciarPantalla();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //* Si estado es -1 indica que el libro no se ha encontrado.
            //* Cualquier otro valor devuelto, indicará que el libro se ha encontrado y la insercción ha sido correcta.
            int estado = acceso.ModificarLibro(RecogerDatosPantalla());
            if (estado != -1)
            {
                MostrarMensaje("Libro Modificado Correctamente");
            }
            else
            {
               MostrarMensaje("Libro no encontrado");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            EnviarDatosAPantalla(acceso.BuscarLibro(lstLibros.SelectedItem.ToString()));
        }
        //*****************************  MÉTODOS  PRIVADOS INTERNOS DE LA CLASE  ******************

        /******************************************************************************************
         * Metodo para recoger los datos
         * Se encarga de montar un libro a través de los datos que introduces en la ventana gráfica
         ******************************************************************************************/

        private Libro RecogerDatosPantalla()
    {
        Libro libro = null;
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
        tema = cbxTemas.SelectedItem.ToString();
        if (rdbNovedad.Checked)
        {
            estado = "novedad";
        }
        else
        {
            estado = "reedicion";
        }

        if (titulo.Count() != 0 && paginas.Count() != 0 && titulo.Count() != 0 && precio.Count() != 0)
        {
            libro = new Libro(autor, titulo, tema, paginas, precio, formatoUno, formatoDos, formatoTres, estado);
        }
        return libro;
    }
    /*********************************************************************************************
     * Pasamos por parametro un libro y este método se encargará de mostrarnos en la parte gráfica
     * todo el contenido del libro.
     *********************************************************************************************/
    private void EnviarDatosAPantalla(Libro sender)
        {
            txtAutor.Text = sender.Autor;
            txtPaginas.Text = sender.Paginas;
            txtPrecio.Text = sender.Precio + " €";
            txtTitulo.Text = sender.Titulo;
            cbxTemas.Text = sender.Tema;
            if (sender.Estado.Equals("reedicion"))
            {
                rdbReedicion.Checked = true;
                rdbNovedad.Checked = false;
            }
            else
            {
                rdbNovedad.Checked = true;
                rdbReedicion.Checked = false;
            }

            chkCartone.Checked = sender.Formatouno.Equals("Cartoné") ? true : false;
            chkRustica.Checked = sender.Formatodos.Equals("Rústica") ? true : false; ;
            chkTapaDura.Checked = sender.Formatotres.Equals("Tapa dura") ? true : false;
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
            rdbReedicion.Checked = false;
            chkCartone.Checked = false;
            chkRustica.Checked = false;
            chkTapaDura.Checked = false;
            cbxTemas.SelectedIndex = -1;
        }

        private void cbxTemas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
