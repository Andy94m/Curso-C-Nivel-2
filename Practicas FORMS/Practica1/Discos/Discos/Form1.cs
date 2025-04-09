using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Discos
{
    public partial class Form1 : Form
    {
        private List<Album> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvAlbum_SelectionChanged(object sender, EventArgs e)
        {
            Album seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);

            /*var genero = dgvAlbum.CurrentRow.Cells["Genero"].Value;
            var formato = dgvAlbum.CurrentRow.Cells["Formato"].Value;
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Formato: " + formato);*/
        }

        private void cargar()
        {
            AlbumNegocio negocio = new AlbumNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvAlbum.DataSource= listaDiscos;
                dgvAlbum.Columns["UrlImagen"].Visible = false;
                dgvAlbum.Columns["Numero"].Visible= false;
                cargarImagen(listaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaAlbum alta = new frmAltaAlbum();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Album seleccionado;
            seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;
            frmAltaAlbum modificar = new frmAltaAlbum(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void Eliminar(bool bandera = false)
        {
            AlbumNegocio negocio = new AlbumNegocio();
            Album seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;

                    if (bandera)
                        negocio.eliminarLogico(seleccionado.Numero);
                    else
                        negocio.eliminar(seleccionado.Numero);

                    MessageBox.Show("Eliminado correctamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
