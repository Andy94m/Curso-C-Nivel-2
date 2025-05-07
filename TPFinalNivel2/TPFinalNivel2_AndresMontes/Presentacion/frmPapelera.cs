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
        public bool cierrePap { get; private set; } = false;
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

        private void btnPapElim_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            try
            {
                
                if (seleccionado != null)
                {
                    seleccionado = (Articulo)dgvPapelera.CurrentRow.DataBoundItem;
                    negocio.eliminarFisico(seleccionado.Id);
                }

                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnPapRest_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<int> idSeleccionados = new List<int>();

            try
            {
                foreach(DataGridViewRow fila in dgvPapelera.SelectedRows)
                {
                    if(fila.DataBoundItem is Articulo articulo)
                    {
                        idSeleccionados.Add(articulo.Id);
                    }
                }

                foreach (int id in idSeleccionados)
                {
                    negocio.restaurarEliminado(id);
                }

                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void frmPapelera_FormClosed(object sender, FormClosedEventArgs e)
        {
            cierrePap = true;
        }

        private void btnPapVaciar_Click(object sender, EventArgs e)
        {
            vaciar();
            cargar();
        }
        private void vaciar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listarExcluidos();
            try
            {
                if (listaArticulos != null) 
                {
                    foreach (Articulo seleccionado in listaArticulos)
                    {
                        //Console.WriteLine("holakase id: " + seleccionado.Id);
                        negocio.eliminarFisico(seleccionado.Id);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
