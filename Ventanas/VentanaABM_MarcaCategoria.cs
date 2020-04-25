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
    public partial class VentanaABM_MarcaCategoria : Form
    {
        private Marca marca = null;
        private Categoria categoria = null;

        #region Constructores

        public VentanaABM_MarcaCategoria()
        {
            InitializeComponent();
        }

        public VentanaABM_MarcaCategoria(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        public VentanaABM_MarcaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        #endregion

        #region Controles Eventos

        private void VentanaABM_Marca_Load(object sender, EventArgs e)
        {
            if (marca == null)
            {
                Text = "Categoria";
                grBNuevaMarca.Text = "Nueva Categoria";
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtBNombre.Text == "")
            {
                MessageBox.Show("Complete el campo Nombre para continuar");
            }else if(marca == null)
                {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                try
                {
                    categoria.Eliminado = false;
                    categoria.Descripcion = txtBNombre.Text;
                    if (!categoriaNegocio.BuscarCategoria(categoria.Descripcion.ToLower()))
                    {
                    categoriaNegocio.Alta(categoria);
                    MessageBox.Show("Categoria agregada exitosamente.");
                    Dispose();
                    }else
                    {
                        MessageBox.Show("La categoria ya esta creada");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                }
                else
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                try
                {
                    marca.Eliminado = false;
                    marca.Descripcion = txtBNombre.Text;
                    if (!marcaNegocio.BuscarNombre(marca.Descripcion.ToLower()))
                    {
                    marcaNegocio.Alta(marca);
                    MessageBox.Show("Marca agregada exitosamente.");
                    Dispose();
                    }
                    else
                    {
                        MessageBox.Show("La marca ya existe.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion
    }
}
