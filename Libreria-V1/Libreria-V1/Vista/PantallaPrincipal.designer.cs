namespace Libreria_V1
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLibreria = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.gpbFormato = new System.Windows.Forms.GroupBox();
            this.chkTapaDura = new System.Windows.Forms.CheckBox();
            this.chkRustica = new System.Windows.Forms.CheckBox();
            this.chkCartone = new System.Windows.Forms.CheckBox();
            this.gpbEstado = new System.Windows.Forms.GroupBox();
            this.rdbReedicion = new System.Windows.Forms.RadioButton();
            this.rdbNovedad = new System.Windows.Forms.RadioButton();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbxTemas = new System.Windows.Forms.ComboBox();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.pnlBotones.SuspendLayout();
            this.gpbFormato.SuspendLayout();
            this.gpbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLibreria
            // 
            this.lblLibreria.AutoSize = true;
            this.lblLibreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLibreria.Location = new System.Drawing.Point(40, 44);
            this.lblLibreria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibreria.Name = "lblLibreria";
            this.lblLibreria.Size = new System.Drawing.Size(402, 91);
            this.lblLibreria.TabIndex = 0;
            this.lblLibreria.Text = "LIBRERIA";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(36, 221);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(80, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.Location = new System.Drawing.Point(37, 271);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(75, 29);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTema.Location = new System.Drawing.Point(33, 325);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(82, 29);
            this.lblTema.TabIndex = 3;
            this.lblTema.Text = "Tema:";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaginas.Location = new System.Drawing.Point(37, 378);
            this.lblPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(106, 29);
            this.lblPaginas.TabIndex = 4;
            this.lblPaginas.Text = "Páginas:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(36, 432);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(89, 29);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnNuevo);
            this.pnlBotones.Controls.Add(this.btnBaja);
            this.pnlBotones.Controls.Add(this.btnAlta);
            this.pnlBotones.Location = new System.Drawing.Point(253, 629);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(321, 249);
            this.pnlBotones.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(63, 168);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 76);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(171, 89);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 69);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(24, 89);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 69);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBaja.Location = new System.Drawing.Point(171, 6);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(125, 65);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.Location = new System.Drawing.Point(24, 6);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(125, 65);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // gpbFormato
            // 
            this.gpbFormato.Controls.Add(this.chkTapaDura);
            this.gpbFormato.Controls.Add(this.chkRustica);
            this.gpbFormato.Controls.Add(this.chkCartone);
            this.gpbFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbFormato.Location = new System.Drawing.Point(43, 535);
            this.gpbFormato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbFormato.Name = "gpbFormato";
            this.gpbFormato.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbFormato.Size = new System.Drawing.Size(169, 194);
            this.gpbFormato.TabIndex = 7;
            this.gpbFormato.TabStop = false;
            this.gpbFormato.Text = "Formato";
            // 
            // chkTapaDura
            // 
            this.chkTapaDura.AutoSize = true;
            this.chkTapaDura.Location = new System.Drawing.Point(13, 135);
            this.chkTapaDura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTapaDura.Name = "chkTapaDura";
            this.chkTapaDura.Size = new System.Drawing.Size(157, 33);
            this.chkTapaDura.TabIndex = 2;
            this.chkTapaDura.Text = "Tapa Dura";
            this.chkTapaDura.UseVisualStyleBackColor = true;
            // 
            // chkRustica
            // 
            this.chkRustica.AutoSize = true;
            this.chkRustica.Location = new System.Drawing.Point(13, 95);
            this.chkRustica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRustica.Name = "chkRustica";
            this.chkRustica.Size = new System.Drawing.Size(121, 33);
            this.chkRustica.TabIndex = 1;
            this.chkRustica.Text = "Rústica";
            this.chkRustica.UseVisualStyleBackColor = true;
            // 
            // chkCartone
            // 
            this.chkCartone.AutoSize = true;
            this.chkCartone.Location = new System.Drawing.Point(13, 49);
            this.chkCartone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCartone.Name = "chkCartone";
            this.chkCartone.Size = new System.Drawing.Size(127, 33);
            this.chkCartone.TabIndex = 0;
            this.chkCartone.Text = "Cartoné";
            this.chkCartone.UseVisualStyleBackColor = true;
            // 
            // gpbEstado
            // 
            this.gpbEstado.Controls.Add(this.rdbReedicion);
            this.gpbEstado.Controls.Add(this.rdbNovedad);
            this.gpbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gpbEstado.Location = new System.Drawing.Point(617, 535);
            this.gpbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbEstado.Name = "gpbEstado";
            this.gpbEstado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbEstado.Size = new System.Drawing.Size(165, 194);
            this.gpbEstado.TabIndex = 8;
            this.gpbEstado.TabStop = false;
            this.gpbEstado.Text = "Estado";
            // 
            // rdbReedicion
            // 
            this.rdbReedicion.AutoSize = true;
            this.rdbReedicion.Location = new System.Drawing.Point(13, 94);
            this.rdbReedicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbReedicion.Name = "rdbReedicion";
            this.rdbReedicion.Size = new System.Drawing.Size(153, 33);
            this.rdbReedicion.TabIndex = 1;
            this.rdbReedicion.Text = "Reedición";
            this.rdbReedicion.UseVisualStyleBackColor = true;
            // 
            // rdbNovedad
            // 
            this.rdbNovedad.AutoSize = true;
            this.rdbNovedad.Checked = true;
            this.rdbNovedad.Location = new System.Drawing.Point(13, 48);
            this.rdbNovedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNovedad.Name = "rdbNovedad";
            this.rdbNovedad.Size = new System.Drawing.Size(139, 33);
            this.rdbNovedad.TabIndex = 0;
            this.rdbNovedad.TabStop = true;
            this.rdbNovedad.Text = "Novedad";
            this.rdbNovedad.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(145, 221);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(277, 30);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(145, 274);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(277, 30);
            this.txtAutor.TabIndex = 10;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaginas.Location = new System.Drawing.Point(145, 378);
            this.txtPaginas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(277, 30);
            this.txtPaginas.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(145, 432);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(277, 30);
            this.txtPrecio.TabIndex = 13;
            // 
            // cbxTemas
            // 
            this.cbxTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTemas.FormattingEnabled = true;
            this.cbxTemas.Location = new System.Drawing.Point(145, 328);
            this.cbxTemas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTemas.Name = "cbxTemas";
            this.cbxTemas.Size = new System.Drawing.Size(277, 33);
            this.cbxTemas.TabIndex = 14;
            this.cbxTemas.SelectedIndexChanged += new System.EventHandler(this.cbxTemas_SelectedIndexChanged);
            // 
            // lstLibros
            // 
            this.lstLibros.AccessibleDescription = "LstLibros_Click";
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 20;
            this.lstLibros.Location = new System.Drawing.Point(505, 180);
            this.lstLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(289, 324);
            this.lstLibros.TabIndex = 15;
            this.lstLibros.Click += new System.EventHandler(this.LstLibros_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensaje.Location = new System.Drawing.Point(505, 120);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(289, 30);
            this.txtMensaje.TabIndex = 18;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 880);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.cbxTemas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.gpbEstado);
            this.Controls.Add(this.gpbFormato);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLibreria);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libreria";
            this.Load += new System.EventHandler(this.Form_Load);
            this.pnlBotones.ResumeLayout(false);
            this.gpbFormato.ResumeLayout(false);
            this.gpbFormato.PerformLayout();
            this.gpbEstado.ResumeLayout(false);
            this.gpbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibreria;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.GroupBox gpbFormato;
        private System.Windows.Forms.CheckBox chkTapaDura;
        private System.Windows.Forms.CheckBox chkRustica;
        private System.Windows.Forms.CheckBox chkCartone;
        private System.Windows.Forms.GroupBox gpbEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbxTemas;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.RadioButton rdbReedicion;
        private System.Windows.Forms.RadioButton rdbNovedad;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}

