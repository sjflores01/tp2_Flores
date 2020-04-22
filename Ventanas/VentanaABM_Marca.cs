using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModeloDominio;
using Negocio;

namespace Ventanas
{
    public partial class VentanaABM_Marca : Form
    {
        public VentanaABM_Marca()
        {
            InitializeComponent();
        }

        private void VentanaABM_Marca_Load(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                marca.Eliminado = false;
                marca.Descripcion = txtBNombre.Text;
                marcaNegocio.Alta(marca);

                MessageBox.Show("Marca agregada exitosamente.");
                Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
