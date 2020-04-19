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
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            try
            {
                dgvListadoArticulos.DataSource = articulo.ListarArticulos();
                dgvListadoArticulos.Columns[0].Visible = false;
                dgvListadoArticulos.Columns[3].Visible = false;
                dgvListadoArticulos.Columns[5].Visible = false;
                dgvListadoArticulos.Columns[6].Visible = false;
                dgvListadoArticulos.Columns[7].Visible = false;
                dgvListadoArticulos.Columns[8].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListadoArticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Articulo articulo = new Articulo();

                articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                picBox.Load(articulo.Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaABM_Articulo nuevoArticulo = new VentanaABM_Articulo();
            nuevoArticulo.ShowDialog();
        }
    }
}
