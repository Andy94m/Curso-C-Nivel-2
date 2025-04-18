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
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Año");
            cboCampo.Items.Add("Cant.Canciones");
        }

        private void dgvAlbum_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlbum.CurrentRow != null)
            {
                Album seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargar()
        {
            AlbumNegocio negocio = new AlbumNegocio();
            
            try
            {
                listaDiscos = negocio.listar();
                dgvAlbum.DataSource= listaDiscos;
                ocultarColumnas();
                cargarImagen(listaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvAlbum.Columns["UrlImagen"].Visible = false;
            dgvAlbum.Columns["Numero"].Visible = false;
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

                    //MessageBox.Show("Eliminado correctamente");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Album> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaDiscos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Genero.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaDiscos;
            }

            dgvAlbum.DataSource = null;
            dgvAlbum.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            AlbumNegocio negocio = new AlbumNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAdv.Text;
                dgvAlbum.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
        }
    }
}
