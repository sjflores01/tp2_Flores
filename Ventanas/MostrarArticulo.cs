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
    public partial class MostrarArticulo : Form
    {
        public Articulo articulo;

        public MostrarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void MostrarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                Text = articulo.Codigo + " - " + articulo.Nombre;
                txtBCodigo.Text = articulo.Codigo;
                txtBNombre.Text = articulo.Nombre;
                txtBDescripcion.Text = articulo.Descripcion;
                txtBMarca.Text = articulo.Marca.Descripcion;
                txtBCategoria.Text = articulo.Categoria.Descripcion;
                txtBPrecio.Text = articulo.Precio.ToString(string.Format("F2"));
                picBoxArticulo.Load(articulo.Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
