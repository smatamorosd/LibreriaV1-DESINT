namespace Libreria_V2
{
    partial class PantallaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.cbxTemas = new System.Windows.Forms.ComboBox();
            this.gpbFormato = new System.Windows.Forms.GroupBox();
            this.chkTapaDura = new System.Windows.Forms.CheckBox();
            this.chkRustica = new System.Windows.Forms.CheckBox();
            this.chkCartone = new System.Windows.Forms.CheckBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.lblLibreria = new System.Windows.Forms.Label();
            this.rbNovedad = new System.Windows.Forms.RadioButton();
            this.rbReedicion = new System.Windows.Forms.RadioButton();
            this.gpbEstado = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.gpbFormato.SuspendLayout();
            this.gpbEstado.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();



            
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(30, 150);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 28);
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(122, 154);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(247, 27);
            this.txtTitulo.TabIndex = 4;
            // 
            // lstLibros
            // 
            this.lstLibros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 28;
            this.lstLibros.Location = new System.Drawing.Point(530, 117);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(346, 536);
            this.lstLibros.Click += new System.EventHandler(this.LstLibros_Click);
            // 
            // cbxTemas
            // 
            this.cbxTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemas.FormattingEnabled = true;
            this.cbxTemas.Items.AddRange(new object[] {
            "Accion",
            "Informatica",
            "Aventura",
            "Romantica",
            "Tupidora",
            "Ficion"});
            this.cbxTemas.Location = new System.Drawing.Point(122, 241);
            this.cbxTemas.Name = "cbxTemas";
            this.cbxTemas.Size = new System.Drawing.Size(247, 28);
            this.cbxTemas.TabIndex = 3;
            this.cbxTemas.SelectedIndexChanged += new System.EventHandler(this.cbxTemas_SelectedIndexChanged);
            // 
            // gpbFormato
            // 
            this.gpbFormato.Controls.Add(this.chkTapaDura);
            this.gpbFormato.Controls.Add(this.chkRustica);
            this.gpbFormato.Controls.Add(this.chkCartone);
            this.gpbFormato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbFormato.Location = new System.Drawing.Point(12, 371);
            this.gpbFormato.Name = "gpbFormato";
            this.gpbFormato.Size = new System.Drawing.Size(225, 151);
            this.gpbFormato.TabIndex = 4;
            this.gpbFormato.TabStop = false;
            this.gpbFormato.Text = "Formato";
            // 
            // chkTapaDura
            // 
            this.chkTapaDura.AutoSize = true;
            this.chkTapaDura.Location = new System.Drawing.Point(15, 109);
            this.chkTapaDura.Name = "chkTapaDura";
            this.chkTapaDura.Size = new System.Drawing.Size(130, 32);
            this.chkTapaDura.TabIndex = 2;
            this.chkTapaDura.Text = "Tapa Dura";
            this.chkTapaDura.UseVisualStyleBackColor = true;
            // 
            // chkRustica
            // 
            this.chkRustica.AutoSize = true;
            this.chkRustica.Location = new System.Drawing.Point(15, 71);
            this.chkRustica.Name = "chkRustica";
            this.chkRustica.Size = new System.Drawing.Size(103, 32);
            this.chkRustica.TabIndex = 1;
            this.chkRustica.Text = "Rústica";
            this.chkRustica.UseVisualStyleBackColor = true;
            // 
            // chkCartone
            // 
            this.chkCartone.AutoSize = true;
            this.chkCartone.Location = new System.Drawing.Point(15, 33);
            this.chkCartone.Name = "chkCartone";
            this.chkCartone.Size = new System.Drawing.Size(109, 32);
            this.chkCartone.TabIndex = 0;
            this.chkCartone.Text = "Cartoné";
            this.chkCartone.UseVisualStyleBackColor = true;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(27, 194);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(66, 28);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(27, 329);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(71, 28);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTema.Location = new System.Drawing.Point(27, 241);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(62, 28);
            this.lblTema.TabIndex = 8;
            this.lblTema.Text = "Tema";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaginas.Location = new System.Drawing.Point(27, 286);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(85, 28);
            this.lblPaginas.TabIndex = 9;
            this.lblPaginas.Text = "Páginas";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 329);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(247, 27);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(122, 286);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(247, 27);
            this.txtPaginas.TabIndex = 10;
            this.txtPaginas.TextChanged += new System.EventHandler(this.txtPaginas_TextChanged);
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPaginas_KeyPress);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(122, 198);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(247, 27);
            this.txtAutor.TabIndex = 6;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(530, 63);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(346, 27);
            this.txtMensaje.TabIndex = 13;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajes.Location = new System.Drawing.Point(428, 62);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(96, 28);
            this.lblMensajes.TabIndex = 14;
            this.lblMensajes.Text = "Mensaje:";
            // 
            // lblLibreria
            // 
            this.lblLibreria.AutoSize = true;
            this.lblLibreria.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLibreria.Location = new System.Drawing.Point(51, 45);
            this.lblLibreria.Name = "lblLibreria";
            this.lblLibreria.Size = new System.Drawing.Size(328, 89);
            this.lblLibreria.TabIndex = 16;
            this.lblLibreria.Text = "LIBRERIA";
            // 
            // rbNovedad
            // 
            this.rbNovedad.AutoSize = true;
            this.rbNovedad.Location = new System.Drawing.Point(18, 33);
            this.rbNovedad.Name = "rbNovedad";
            this.rbNovedad.Size = new System.Drawing.Size(118, 32);
            this.rbNovedad.TabIndex = 0;
            this.rbNovedad.TabStop = true;
            this.rbNovedad.Text = "Novedad";
            this.rbNovedad.UseVisualStyleBackColor = true;
            this.rbNovedad.CheckedChanged += new System.EventHandler(this.RdbNovedad_CheckedChanged);
            // 
            // rbReedicion
            // 
            this.rbReedicion.AutoSize = true;
            this.rbReedicion.Location = new System.Drawing.Point(18, 71);
            this.rbReedicion.Name = "rbReedicion";
            this.rbReedicion.Size = new System.Drawing.Size(126, 32);
            this.rbReedicion.TabIndex = 1;
            this.rbReedicion.TabStop = true;
            this.rbReedicion.Text = "Reedición";
            this.rbReedicion.UseVisualStyleBackColor = true;
            this.rbReedicion.Click += new System.EventHandler(this.RdbReedicion_CheckedChanged);
            // 
            // gpbEstado
            // 
            this.gpbEstado.Controls.Add(this.rbReedicion);
            this.gpbEstado.Controls.Add(this.rbNovedad);
            this.gpbEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbEstado.Location = new System.Drawing.Point(243, 371);
            this.gpbEstado.Name = "gpbEstado";
            this.gpbEstado.Size = new System.Drawing.Size(217, 151);
            this.gpbEstado.TabIndex = 5;
            this.gpbEstado.TabStop = false;
            this.gpbEstado.Text = "Estado";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(16, 11);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(94, 29);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 48);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 48);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(140, 11);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(94, 29);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(51, 83);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnBaja);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnAlta);
            this.pnlBotones.Location = new System.Drawing.Point(210, 528);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(250, 125);
            this.pnlBotones.TabIndex = 15;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 695);
            this.Controls.Add(this.lblLibreria);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.gpbEstado);
            this.Controls.Add(this.gpbFormato);
            this.Controls.Add(this.cbxTemas);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.gpbFormato.ResumeLayout(false);
            this.gpbFormato.PerformLayout();
            this.gpbEstado.ResumeLayout(false);
            this.gpbEstado.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private ListBox lstLibros;
        private ComboBox cbxTemas;
        private GroupBox gpbFormato;
        private Label lblAutor;
        private Label lblPrecio;
        private Label lblTema;
        private Label lblPaginas;
        private TextBox txtPrecio;
        private TextBox txtPaginas;
        private TextBox txtAutor;
        private CheckBox chkTapaDura;
        private CheckBox chkRustica;
        private CheckBox chkCartone;
        private TextBox txtMensaje;
        private Label lblMensajes;
        private Label lblLibreria;
        private RadioButton rbNovedad;
        private RadioButton rbReedicion;
        private GroupBox gpbEstado;
        private Button btnAlta;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnSalir;
        private Panel pnlBotones;
    }

}