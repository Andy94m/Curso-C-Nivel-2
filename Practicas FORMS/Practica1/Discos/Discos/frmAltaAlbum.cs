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

            try
            {
                disco.Nombre = txtNombre.Text;
                disco.Fecha = dtpFecha.Value;
                disco.Canciones = int.Parse(txtCant.Text);

                negocio.agregar(disco);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
