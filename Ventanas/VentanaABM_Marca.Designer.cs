namespace Ventanas
{
    partial class VentanaABM_Marca
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.grBNuevaMarca = new System.Windows.Forms.GroupBox();
            this.grBNuevaMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(83, 125);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 37);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 125);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(72, 28);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(202, 20);
            this.txtBNombre.TabIndex = 3;
            // 
            // grBNuevaMarca
            // 
            this.grBNuevaMarca.Controls.Add(this.txtBNombre);
            this.grBNuevaMarca.Controls.Add(this.lblNombre);
            this.grBNuevaMarca.Location = new System.Drawing.Point(12, 41);
            this.grBNuevaMarca.Name = "grBNuevaMarca";
            this.grBNuevaMarca.Size = new System.Drawing.Size(318, 69);
            this.grBNuevaMarca.TabIndex = 4;
            this.grBNuevaMarca.TabStop = false;
            this.grBNuevaMarca.Text = "Nueva Marca";
            // 
            // VentanaABM_Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 193);
            this.Controls.Add(this.grBNuevaMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaABM_Marca";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.VentanaABM_Marca_Load);
            this.grBNuevaMarca.ResumeLayout(false);
            this.grBNuevaMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.GroupBox grBNuevaMarca;
    }
}