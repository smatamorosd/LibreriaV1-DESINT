using LibreriaV5_Final.Comun;
using LibreriaV5_Final.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibreriaV5_Final.Vista
{
    public partial class FrmClientes : Form
    {
        private ControlAccesoDAO<object> controlAccesoDAO = new ControlAccesoDAO<object>();

        public FrmClientes()
        {
            InitializeComponent();
            obtenerClientes();
        }
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            //Recoger los datos del formulario
            lstClientes.SelectedIndex = -1;
            TCliente cliente = recogerDatosForm();
            if(cliente == null)
            {
                MessageBox.Show(Mensajes.MSG_CAMPOSVACIOS);
                return;
            }

            if(controlAccesoDAO.BuscarOne(cliente.GetType(), cliente.CodCliente) != null)
            {
                MessageBox.Show(Mensajes.MSG_YAEXISTE_CLIENTE);
                return;
            }

            if (controlAccesoDAO.Insertar(cliente))
            {
                lstClientes.Items.Add(cliente);
                MessageBox.Show(Mensajes.MSG_INSERTADO_CLIENTE);
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {

            if(lstClientes.SelectedItem != null)
            {
                controlAccesoDAO.BorradoVirtual(lstClientes.SelectedItem);

                MessageBox.Show(Mensajes.MSG_BORRADO_CLIENTE);
                lstClientes.Items.Remove(lstClientes.SelectedItem);
                limpiarPantalla();
            }


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            TCliente cliente = recogerDatosForm();
            if(lstClientes.SelectedItem != null && controlAccesoDAO.Modificar(cliente))
            {
                lstClientes.Items.Remove(lstClientes.SelectedItem);
                lstClientes.Items.Add(cliente);
                MessageBox.Show(Mensajes.MSG_MODIFICADO_CLIENTE);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedItem != null)
            {
                EnviarAPantalla((TCliente)lstClientes.SelectedItem);
            }
        }

        /*
         * *******************************************
         * *            MÉTODOS PRIVADOS             *
         * *******************************************
        */

        private TCliente recogerDatosForm()
        {

            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            String email = txtEmail.Text;
            String direccion = txtDireccion.Text;
            String DNI = txtDNI.Text;

            if(nombre.Count() == 0 && apellidos.Count() == 0 && email.Count() == 0
                 && direccion.Count() == 0 && DNI.Count() == 0) {
                return null;
            }

            //Si NO hay ningun cliente seleccionado es un alta.
            if( ((TCliente)lstClientes.SelectedItem) == null)
            {
                return new TCliente(nombre, apellidos, DNI,direccion,email);
            }

            //Si hay un cliente seleccionado es una modificacion, recogemos su ID
            String codCliente = ((TCliente)lstClientes.SelectedItem).CodCliente;
            return new TCliente(codCliente, nombre, apellidos, DNI, direccion, email, "0");

        }

        private void EnviarAPantalla(TCliente datos)
        {

            txtNombre.Text = datos.Nombre;
            txtApellidos.Text = datos.Apellidos;
            txtDNI.Text = datos.DNI;
            txtDireccion.Text = datos.Direccion;
            txtEmail.Text = datos.Email;

        }

        private void limpiarPantalla()
        {

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";

            lstClientes.SelectedIndex = -1;

        }

        private void obtenerClientes()
        {
            
            //Recogemos los clientes y los añadimos al listbox.
            foreach (TCliente cliente in controlAccesoDAO.BuscarAll(new TCliente().GetType()))
            {
                if(cliente.Borrado == "0")
                {
                    lstClientes.Items.Add(cliente);
                }
            }

        }
    }
}
