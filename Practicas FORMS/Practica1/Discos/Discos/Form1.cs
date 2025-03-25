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
            AlbumNegocio negocio = new AlbumNegocio();
            listaDiscos = negocio.listar();
            dgvAlbum.DataSource = listaDiscos;
            cargarImagen(listaDiscos[0].UrlImagen);
        }

        private void dgvAlbum_SelectionChanged(object sender, EventArgs e)
        {
            Album seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
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
