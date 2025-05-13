using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Dominio;
using Negocio;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        Validaciones validar = new Validaciones();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboColumna.Items.Add("Codigo");
            cboColumna.Items.Add("Nombre");
            cboColumna.Items.Add("Descripcion");
            cboColumna.Items.Add("Precio");
            cboColumna.Items.Add("Compania");
            cboColumna.Items.Add("Tipo");

            cboOrdCol.Items.Add("Default");
            cboOrdCol.Items.Add("Nombre");
            cboOrdCol.Items.Add("Compania");
            cboOrdCol.Items.Add("Tipo");
            cboOrdCol.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                Console.WriteLine("listar: " + listaArticulos.ToString());
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";
                ocultarColumnas();
                validar.cargarImagen(pcbCatalogo, listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null) 
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                validar.cargarImagen(pcbCatalogo, seleccionado.UrlImagen);
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmArticuloAlta alta = new frmArticuloAlta();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmArticuloAlta modificar = new frmArticuloAlta(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo a modificar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void eliminarLogico()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<int> idSeleccionados = new List<int>();

            try
            {
                foreach (DataGridViewRow fila in dgvArticulos.SelectedRows)
                {
                    if (fila.DataBoundItem is Articulo articulo)
                    {
                        idSeleccionados.Add(articulo.Id);
                    }
                }

                if (idSeleccionados.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un elemento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje;
                if (idSeleccionados.Count == 1)
                {
                    mensaje = "¿Desea enviar este elemento a la papelera?";
                }
                else
                {
                    mensaje = "¿Desea enviar estos elementos a la papelera?";
                }

                DialogResult respuesta = MessageBox.Show(mensaje, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    foreach (int id in idSeleccionados)
                    {
                        negocio.eliminarLogico(id);
                    }

                    cargar(); // Recargar la grilla después de eliminar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            eliminarLogico();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Cod.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Compania.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";
            ocultarColumnas();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string columna = cboColumna.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBusqFiltro.Text;
                Console.WriteLine(columna + " " + criterio + " " + filtro);
                dgvArticulos.DataSource = negocio.filtrar(columna, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboColumna.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una columna");
                return true;
            }

            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }

            if(cboColumna.SelectedItem.ToString() == "Codigo" || cboColumna.SelectedItem.ToString() == "Nombre")
            {
                if(txtBusqFiltro.Text == "")
                {
                    MessageBox.Show("Ingrese un valor a buscar");
                    return true;
                }
            }
            return false;
        }

        private void cboColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboColumna.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void txtBusqFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (cboColumna.SelectedIndex < 0)
                {
                    validarFiltro();
                }
                else if (cboColumna.SelectedItem.ToString() == "Precio")
                {
                    validar.SoloNumeros(e);
                }
                else
                    validar.NoSimbol(e);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmArticuloUnit unitario = new frmArticuloUnit(seleccionado);
            unitario.ShowDialog();
            cargar();
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            frmPapelera papelera = new frmPapelera();
            papelera.ShowDialog();

            if (papelera.cierrePap)
                cargar();
        }

        private void cboOrdCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboOrdCol.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboOrdCri.Items.Clear();
                cboOrdCri.Items.Add("Menor a mayor");
                cboOrdCri.Items.Add("Mayor a menor");
            }
            else if (opcion == "Default")
            {
                cargar();
                cboOrdCri.Items.Clear();
            }
            else
            {
                cboOrdCri.Items.Clear();
                cboOrdCri.Items.Add("Alfabeticamente A - Z");
                cboOrdCri.Items.Add("Alfabeticamente Z - A");
            }
        }

        private void cboOrdCri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboOrdCri.SelectedIndex;
            string columna = cboOrdCol.SelectedItem.ToString();
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();

            Console.WriteLine(columna + " INDEX: " + index );

            try
            {
                if (columna == "Precio")
                {
                    if (index == 0)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderBy(a => a.Precio).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                    else if (index == 1)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderByDescending(a => a.Precio).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                }
                else if(columna == "Nombre")
                {
                    if (index == 0)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderBy(a => a.Nombre).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                    else if (index == 1)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderByDescending(a => a.Nombre).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                }
                else if( columna == "Compania")
                {
                    if (index == 0)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderBy(a => a.Compania.Descripcion).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                    else if (index == 1)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderByDescending(a => a.Compania.Descripcion).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                }
                else if (columna == "Tipo")
                {
                    if (index == 0)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderBy(a => a.Tipo.Descripcion).ToList();
                        dgvArticulos.DataSource = ordenados;
                    }
                    else if (index == 1)
                    {
                        List<Articulo> ordenados = listaArticulos.OrderByDescending(a => a.Tipo.Descripcion).ToList();
                        dgvArticulos.DataSource = ordenados;
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
