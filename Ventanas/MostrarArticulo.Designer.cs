namespace Ventanas
{
    partial class MostrarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarArticulo));
            this.btnAtras = new System.Windows.Forms.Button();
            this.grBoxNuevoArticulo = new System.Windows.Forms.GroupBox();
            this.txtBCategoria = new System.Windows.Forms.TextBox();
            this.txtBMarca = new System.Windows.Forms.TextBox();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.txtBDescripcion = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.picBoxArticulo = new System.Windows.Forms.PictureBox();
            this.grBoxNuevoArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(434, 451);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(117, 40);
            this.btnAtras.TabIndex = 24;
            this.btnAtras.Text = "&Atras";
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grBoxNuevoArticulo
            // 
            this.grBoxNuevoArticulo.Controls.Add(this.txtBCategoria);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBMarca);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBPrecio);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBDescripcion);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBNombre);
            this.grBoxNuevoArticulo.Controls.Add(this.txtBCodigo);
            this.grBoxNuevoArticulo.Controls.Add(this.lblPrecio);
            this.grBoxNuevoArticulo.Controls.Add(this.lblCategoria);
            this.grBoxNuevoArticulo.Controls.Add(this.lblMarca);
            this.grBoxNuevoArticulo.Controls.Add(this.lblDescripcion);
            this.grBoxNuevoArticulo.Controls.Add(this.lblNombre);
            this.grBoxNuevoArticulo.Controls.Add(this.lblCodigo);
            this.grBoxNuevoArticulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grBoxNuevoArticulo.Location = new System.Drawing.Point(12, 12);
            this.grBoxNuevoArticulo.Name = "grBoxNuevoArticulo";
            this.grBoxNuevoArticulo.Size = new System.Drawing.Size(353, 299);
            this.grBoxNuevoArticulo.TabIndex = 22;
            this.grBoxNuevoArticulo.TabStop = false;
            this.grBoxNuevoArticulo.Text = "Articulo";
            // 
            // txtBCategoria
            // 
            this.txtBCategoria.Enabled = false;
            this.txtBCategoria.Location = new System.Drawing.Point(78, 232);
            this.txtBCategoria.MaxLength = 150;
            this.txtBCategoria.Name = "txtBCategoria";
            this.txtBCategoria.Size = new System.Drawing.Size(253, 20);
            this.txtBCategoria.TabIndex = 15;
            // 
            // txtBMarca
            // 
            this.txtBMarca.Enabled = false;
            this.txtBMarca.Location = new System.Drawing.Point(78, 205);
            this.txtBMarca.MaxLength = 150;
            this.txtBMarca.Name = "txtBMarca";
            this.txtBMarca.Size = new System.Drawing.Size(253, 20);
            this.txtBMarca.TabIndex = 14;
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Enabled = false;
            this.txtBPrecio.Location = new System.Drawing.Point(78, 259);
            this.txtBPrecio.MaxLength = 150;
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(77, 20);
            this.txtBPrecio.TabIndex = 13;
            // 
            // txtBDescripcion
            // 
            this.txtBDescripcion.Enabled = false;
            this.txtBDescripcion.Location = new System.Drawing.Point(78, 78);
            this.txtBDescripcion.MaxLength = 150;
            this.txtBDescripcion.Multiline = true;
            this.txtBDescripcion.Name = "txtBDescripcion";
            this.txtBDescripcion.Size = new System.Drawing.Size(253, 120);
            this.txtBDescripcion.TabIndex = 9;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Enabled = false;
            this.txtBNombre.Location = new System.Drawing.Point(78, 51);
            this.txtBNombre.MaxLength = 50;
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(253, 20);
            this.txtBNombre.TabIndex = 8;
            // 
            // txtBCodigo
            // 
            this.txtBCodigo.Enabled = false;
            this.txtBCodigo.Location = new System.Drawing.Point(78, 24);
            this.txtBCodigo.MaxLength = 50;
            this.txtBCodigo.Name = "txtBCodigo";
            this.txtBCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtBCodigo.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 262);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 235);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 208);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
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
            // picBoxArticulo
            // 
            this.picBoxArticulo.Location = new System.Drawing.Point(397, 12);
            this.picBoxArticulo.Name = "picBoxArticulo";
            this.picBoxArticulo.Size = new System.Drawing.Size(360, 375);
            this.picBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArticulo.TabIndex = 21;
            this.picBoxArticulo.TabStop = false;
            // 
            // MostrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(781, 512);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grBoxNuevoArticulo);
            this.Controls.Add(this.picBoxArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 551);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(797, 551);
            this.Name = "MostrarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MostrarArticulo_Load);
            this.grBoxNuevoArticulo.ResumeLayout(false);
            this.grBoxNuevoArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox grBoxNuevoArticulo;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.TextBox txtBDescripcion;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox picBoxArticulo;
        private System.Windows.Forms.TextBox txtBCategoria;
        private System.Windows.Forms.TextBox txtBMarca;
    }
}