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
        private Articulo articulo = null;

        public VentanaABM_Articulo()
        {
            InitializeComponent();
        }

        public VentanaABM_Articulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void VentanaABM_Articulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cbMarca.DataSource = marca.ListarMarcas();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                cbMarca.SelectedIndex = -1;

                cbCategoria.DataSource = categoria.ListarCartegorias();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbCategoria.SelectedIndex = -1;

                if(articulo != null)
                {
                    Text = "Modificar Articulo";
                    grBoxNuevoArticulo.Text = "Modificar Articulo";
                    txtBCodigo.Text = articulo.Codigo;
                    txtBNombre.Text = articulo.Nombre;
                    txtBDescripcion.Text = articulo.Descripcion;
                    txtBImagen.Text = articulo.Imagen;
                    txtBPrecio.Text = articulo.Precio.ToString();
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            // Articulo articulo = new Articulo();

            try
            {
                if (txtBCodigo.Text == "" ||
                    txtBNombre.Text == "" ||
                    txtBDescripcion.Text == "" ||
                    txtBImagen.Text == "" ||
                    txtBPrecio.Text == "")
                {
                    MessageBox.Show("Por favor complete todos los campos para continuar!");
                }
                else if(articulo == null)
                {
                    articulo = new Articulo();
                }
                    articulo.Codigo = txtBCodigo.Text;
                    articulo.Nombre = txtBNombre.Text;
                    articulo.Descripcion = txtBDescripcion.Text;
                    articulo.Marca = (Marca)cbMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                    articulo.Imagen = txtBImagen.Text;
                    articulo.Precio = Convert.ToDecimal(txtBPrecio.Text);
                    articulo.Eliminado = false;
                if(articulo.Id != 0)
                {
                    articuloNegocio.Modificar(articulo);
                    MessageBox.Show("Modificacion realizada con exito");
                    Dispose();
                }
                else
                {
                    articuloNegocio.Alta(articulo);
                    MessageBox.Show("Articulo agregado");
                    Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtBImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txtBImagen.Text != "")
                {
                pictureBox1.Load(txtBImagen.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("El URL es invalido!");
            }
        }

        private void txtBCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( (e.KeyChar < 48 || e.KeyChar > 57 &&
                e.KeyChar < 65 || e.KeyChar > 90 &&
                e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57 && 
                e.KeyChar < 65 || e.KeyChar > 90 &&
                e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 08 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txtBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) &&
                e.KeyChar != 08 &&
                e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
    }
}
