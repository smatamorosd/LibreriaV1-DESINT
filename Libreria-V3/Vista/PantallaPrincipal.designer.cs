﻿namespace Libreria_V3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTemas = new System.Windows.Forms.ComboBox();
            this.Formato = new System.Windows.Forms.GroupBox();
            this.chkTapaDura = new System.Windows.Forms.CheckBox();
            this.chkRustica = new System.Windows.Forms.CheckBox();
            this.chkCartone = new System.Windows.Forms.CheckBox();
            this.Estado = new System.Windows.Forms.GroupBox();
            this.rbReedicion = new System.Windows.Forms.RadioButton();
            this.rbNovedad = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.Formato.SuspendLayout();
            this.Estado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensajes: ";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensaje.Location = new System.Drawing.Point(507, 74);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(308, 30);
            this.txtMensaje.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.Location = new System.Drawing.Point(123, 145);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(321, 30);
            this.txtTitulo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Título";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(123, 191);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(321, 30);
            this.txtAutor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autor:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(123, 325);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(321, 30);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaginas.Location = new System.Drawing.Point(123, 280);
            this.txtPaginas.MaxLength = 30;
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(321, 30);
            this.txtPaginas.TabIndex = 10;
            this.txtPaginas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPaginas_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Páginas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tema:";
            // 
            // cbxTemas
            // 
            this.cbxTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTemas.FormattingEnabled = true;
            this.cbxTemas.Items.AddRange(new object[] {
            "Accion",
            "Informatica",
            "Aventura",
            "Romantica",
            "Tupidora",
            "Ficion"});
            this.cbxTemas.Location = new System.Drawing.Point(123, 235);
            this.cbxTemas.Name = "cbxTemas";
            this.cbxTemas.Size = new System.Drawing.Size(321, 33);
            this.cbxTemas.TabIndex = 12;
            // 
            // Formato
            // 
            this.Formato.Controls.Add(this.chkTapaDura);
            this.Formato.Controls.Add(this.chkRustica);
            this.Formato.Controls.Add(this.chkCartone);
            this.Formato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Formato.Location = new System.Drawing.Point(40, 403);
            this.Formato.Name = "Formato";
            this.Formato.Size = new System.Drawing.Size(174, 140);
            this.Formato.TabIndex = 13;
            this.Formato.TabStop = false;
            this.Formato.Text = "Formato";
            // 
            // chkTapaDura
            // 
            this.chkTapaDura.AutoSize = true;
            this.chkTapaDura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTapaDura.Location = new System.Drawing.Point(15, 99);
            this.chkTapaDura.Name = "chkTapaDura";
            this.chkTapaDura.Size = new System.Drawing.Size(133, 29);
            this.chkTapaDura.TabIndex = 2;
            this.chkTapaDura.Text = "Tapa dura";
            this.chkTapaDura.UseVisualStyleBackColor = true;
            // 
            // chkRustica
            // 
            this.chkRustica.AutoSize = true;
            this.chkRustica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRustica.Location = new System.Drawing.Point(15, 64);
            this.chkRustica.Name = "chkRustica";
            this.chkRustica.Size = new System.Drawing.Size(105, 29);
            this.chkRustica.TabIndex = 1;
            this.chkRustica.Text = "Rústica";
            this.chkRustica.UseVisualStyleBackColor = true;
            this.chkRustica.CheckedChanged += new System.EventHandler(this.chkRustica_CheckedChanged);
            // 
            // chkCartone
            // 
            this.chkCartone.AutoSize = true;
            this.chkCartone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCartone.Location = new System.Drawing.Point(15, 29);
            this.chkCartone.Name = "chkCartone";
            this.chkCartone.Size = new System.Drawing.Size(111, 29);
            this.chkCartone.TabIndex = 0;
            this.chkCartone.Text = "Cartoné";
            this.chkCartone.UseVisualStyleBackColor = true;
            // 
            // Estado
            // 
            this.Estado.Controls.Add(this.rbReedicion);
            this.Estado.Controls.Add(this.rbNovedad);
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Estado.Location = new System.Drawing.Point(248, 402);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(176, 141);
            this.Estado.TabIndex = 14;
            this.Estado.TabStop = false;
            this.Estado.Text = "Estado";
            // 
            // rbReedicion
            // 
            this.rbReedicion.AutoSize = true;
            this.rbReedicion.Location = new System.Drawing.Point(5, 94);
            this.rbReedicion.Name = "rbReedicion";
            this.rbReedicion.Size = new System.Drawing.Size(128, 29);
            this.rbReedicion.TabIndex = 1;
            this.rbReedicion.TabStop = true;
            this.rbReedicion.Text = "Reedición";
            this.rbReedicion.UseVisualStyleBackColor = true;
            // 
            // rbNovedad
            // 
            this.rbNovedad.AutoSize = true;
            this.rbNovedad.Checked = true;
            this.rbNovedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNovedad.Location = new System.Drawing.Point(5, 51);
            this.rbNovedad.Name = "rbNovedad";
            this.rbNovedad.Size = new System.Drawing.Size(119, 29);
            this.rbNovedad.TabIndex = 0;
            this.rbNovedad.TabStop = true;
            this.rbNovedad.Text = "Novedad";
            this.rbNovedad.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnBaja);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Location = new System.Drawing.Point(123, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 202);
            this.panel1.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(11, 131);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(216, 46);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(123, 77);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 46);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBaja.Location = new System.Drawing.Point(123, 23);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(117, 46);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.Location = new System.Drawing.Point(11, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 46);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.Location = new System.Drawing.Point(11, 23);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(105, 46);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 20;
            this.lstLibros.Location = new System.Drawing.Point(501, 157);
            this.lstLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(314, 404);
            this.lstLibros.TabIndex = 17;
            this.lstLibros.Click += new System.EventHandler(this.LstLibros_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 757);
            this.Controls.Add(this.lstLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Formato);
            this.Controls.Add(this.cbxTemas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Formato.ResumeLayout(false);
            this.Formato.PerformLayout();
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTemas;
        private System.Windows.Forms.GroupBox Formato;
        private System.Windows.Forms.CheckBox chkTapaDura;
        private System.Windows.Forms.CheckBox chkRustica;
        private System.Windows.Forms.CheckBox chkCartone;
        private System.Windows.Forms.GroupBox Estado;
        private System.Windows.Forms.RadioButton rbReedicion;
        private System.Windows.Forms.RadioButton rbNovedad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ListBox lstLibros;
    }
}

