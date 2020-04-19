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
    public partial class VentanaABM_Articulo : Form
    {
        public VentanaABM_Articulo()
        {
            InitializeComponent();
        }

        private void VentanaABM_Articulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbMarca.DataSource = marca.ListarMarcas();
                cbCategoria.DataSource = categoria.ListarCartegorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
