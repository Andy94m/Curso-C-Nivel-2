using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPapelera : Form
    {
        private List <Articulo> listaArticulos;
        public frmPapelera()
        {
            InitializeComponent();
        }
        private void frmPapelera_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listarExcluidos();
                Console.WriteLine("listar: " + listaArticulos.ToString());
                dgvPapelera.DataSource = listaArticulos;
                dgvPapelera.Columns["Precio"].DefaultCellStyle.Format = "F2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvPapelera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPapElim_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            try
            {
                seleccionado = (Articulo)dgvPapelera.CurrentRow.DataBoundItem;
                negocio.eliminarFisico(seleccionado.Id);
                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
