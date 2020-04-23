namespace Ventanas
{
    partial class VentanaABM_Articulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaABM_Articulo));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.txtBImagen = new System.Windows.Forms.TextBox();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBoxNuevoArticulo = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrevImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBoxNuevoArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 108);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 135);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(7, 162);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(65, 13);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Link Imagen";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 189);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Location = new System.Drawing.Point(78, 24);
            this.txtBCodigo.MaxLength = 50;
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(253, 20);
            this.txtBCodigo.TabIndex = 7;
            this.txtBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBCodigo_KeyPress);
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(78, 51);
            this.txtBNombre.MaxLength = 50;
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(253, 20);
            this.txtBNombre.TabIndex = 8;
            this.txtBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNombre_KeyPress);
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Location = new System.Drawing.Point(78, 78);
            this.txtBDescripcion.MaxLength = 150;
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(253, 20);
            this.txtBDescripcion.TabIndex = 9;
            // 
            // txtBImagen
            // 
            this.txtBImagen.Location = new System.Drawing.Point(78, 159);
            this.txtBImagen.MaxLength = 1000;
            this.txtBImagen.Name = "txtBImagen";
            this.txtBImagen.Size = new System.Drawing.Size(253, 20);
            this.txtBImagen.TabIndex = 12;
            this.txtBImagen.Leave += new System.EventHandler(this.txtBImagen_Leave);
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(78, 186);
            this.txtBPrecio.MaxLength = 150;
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtBPrecio.TabIndex = 13;
            this.txtBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBPrecio_KeyPress);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(78, 105);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(146, 21);
            this.cbMarca.TabIndex = 10;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(78, 132);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(146, 21);
            this.cbCategoria.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(402, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // grBoxNuevoArticulo
            // 
            this.grBoxNuevoArticulo.Controls.Add(this.cbCategoria);
            this.grBoxNuevoArticulo.Controls.Add(this.cbMarca);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBPrecio);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBImagen);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBDescripcion);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBNombre);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBCodigo);
            this.grBoxNuevoArticulo.Controls.Add(this.lblPrecio);
            this.grBoxNuevoArticulo.Controls.Add(this.lblImagen);
            this.grBoxNuevoArticulo.Controls.Add(this.lblCategoria);
            this.grBoxNuevoArticulo.Controls.Add(this.lblMarca);
            this.grBoxNuevoArticulo.Controls.Add(this.lblDescripcion);
            this.grBoxNuevoArticulo.Controls.Add(this.lblNombre);
            this.grBoxNuevoArticulo.Controls.Add(this.lblCodigo);
            this.grBoxNuevoArticulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grBoxNuevoArticulo.Location = new System.Drawing.Point(20, 50);
            this.grBoxNuevoArticulo.Name = "grBoxNuevoArticulo";
            this.grBoxNuevoArticulo.Size = new System.Drawing.Size(356, 222);
            this.grBoxNuevoArticulo.TabIndex = 17;
            this.grBoxNuevoArticulo.TabStop = false;
            this.grBoxNuevoArticulo.Text = "Nuevo Articulo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(154, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 40);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrevImagen
            // 
            this.lblPrevImagen.AutoSize = true;
            this.lblPrevImagen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrevImagen.Location = new System.Drawing.Point(400, 85);
            this.lblPrevImagen.Name = "lblPrevImagen";
            this.lblPrevImagen.Size = new System.Drawing.Size(65, 13);
            this.lblPrevImagen.TabIndex = 20;
            this.lblPrevImagen.Text = "Vista previa:";
            // 
            // VentanaABM_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lblPrevImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grBoxNuevoArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "VentanaABM_Articulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.VentanaABM_Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBoxNuevoArticulo.ResumeLayout(false);
            this.grBoxNuevoArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.TextBox txtBImagen;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grBoxNuevoArticulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrevImagen;
    }
}