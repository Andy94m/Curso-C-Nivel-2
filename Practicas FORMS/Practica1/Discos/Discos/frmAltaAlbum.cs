using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Discos
{
    public partial class frmAltaAlbum : Form
    {
        public frmAltaAlbum()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Album disco = new Album();
            AlbumNegocio negocio = new AlbumNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            //var lista = edicionNegocio.listar();
            //Console.WriteLine("Cantidad de elementos en la lista: " + lista.Count);
            //cboEdicion.DataSource = lista;


            try
            {
                disco.Nombre = txtNombre.Text;
                disco.Fecha = dtpFecha.Value;
                disco.Canciones = int.Parse(txtCant.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.Formato = (Edicion)cboEdicion.SelectedItem;
                disco.Genero = (Estilos)cboEstilo.SelectedItem;

                negocio.agregar(disco);
                MessageBox.Show("Agregado exitosamente");


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaAlbum_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstilosNegocio estilosNegocio = new EstilosNegocio();
            //Console.WriteLine("Load fue cargado correctamente \n \n " + edicionNegocio.listar());

            try
            {
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEstilo.DataSource = estilosNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBox1.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBox1.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
