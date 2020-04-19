namespace Ventanas
{
    partial class VentanaInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articuloToolStripMenuItem.Text = "Articulo";
            this.articuloToolStripMenuItem.Click += new System.EventHandler(this.articuloToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(19, 48);
            this.dgvListadoArticulos.MaximumSize = new System.Drawing.Size(400, 315);
            this.dgvListadoArticulos.MultiSelect = false;
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.ReadOnly = true;
            this.dgvListadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(400, 315);
            this.dgvListadoArticulos.TabIndex = 1;
            this.dgvListadoArticulos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListadoArticulos_CellMouseClick);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(427, 48);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(307, 315);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 437);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(776, 476);
            this.Name = "VentanaInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Articulos";
            this.Load += new System.EventHandler(this.VentanaInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.PictureBox picBox;
    }
}

