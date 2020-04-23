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
        List<Articulo> lista;

        #region Constructor

        public VentanaInicio()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private void cargarDatos()
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            try
            {
                lista = articulo.Listar();
                dgvListadoArticulos.DataSource = lista;
                dgvListadoArticulos.Columns[1].Width = 15;
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

        #endregion

        #region Controles Eventos

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            cargarDatos();
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
            cargarDatos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;

            modificar = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            VentanaABM_Articulo VentanaModificar = new VentanaABM_Articulo(modificar);
            VentanaModificar.ShowDialog();
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Id;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
            Id = ((Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem).Id;
            DialogResult resultado;
            resultado = MessageBox.Show("Esta seguro que desea dar de baja el articulo?", "Eliminar Articulo", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                articuloNegocio.Baja(Id);
                MessageBox.Show("Baja realizada con exito.");
            }
            cargarDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Articulo> listaFiltrada;

                if (txtBBuscar.Text == "")
                {
                    listaFiltrada = lista;
                }
                else
                {
                    listaFiltrada = lista.FindAll(l => l.Nombre.ToLower().Contains(txtBBuscar.Text.ToLower()));
                }
                    dgvListadoArticulos.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListadoArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            MostrarArticulo mostrar = new MostrarArticulo(articulo);
            mostrar.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            VentanaABM_MarcaCategoria nuevaMarca = new VentanaABM_MarcaCategoria(marca);
            nuevaMarca.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            VentanaABM_MarcaCategoria nuevaCategoria = new VentanaABM_MarcaCategoria(categoria);
            nuevaCategoria.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaABM_Articulo nuevoArticulo = new VentanaABM_Articulo();
            nuevoArticulo.ShowDialog();
            cargarDatos();
        }

        #endregion

        private void tsmiMarca_CheckStateChanged(object sender, EventArgs e)
        {
            if(tsmiMarca.Checked == true)
            {
                dgvListadoArticulos.Columns[4].Visible = true;
            }
            else
            {
                dgvListadoArticulos.Columns[4].Visible = false;
            }
        }

        private void tsmiCategoria_CheckStateChanged(object sender, EventArgs e)
        {
            if(tsmiCategoria.Checked == true)
            {
                dgvListadoArticulos.Columns[5].Visible = true;                
            }
            else
            {
                dgvListadoArticulos.Columns[5].Visible = false;
            }
        }

        private void tsmiDescripcion_CheckStateChanged(object sender, EventArgs e)
        {
            if(tsmiDescripcion.Checked == true)
            {
                dgvListadoArticulos.Columns[3].Visible = true;
            }
            else
            {
                dgvListadoArticulos.Columns[3].Visible = false;
            }
        }

        private void tsmiPrecio_CheckStateChanged(object sender, EventArgs e)
        {
            if(tsmiPrecio.Checked == true)
            {
                dgvListadoArticulos.Columns[7].Visible = true;
            }
            else
            {
                dgvListadoArticulos.Columns[7].Visible = false;
            }
        }
    }
}
