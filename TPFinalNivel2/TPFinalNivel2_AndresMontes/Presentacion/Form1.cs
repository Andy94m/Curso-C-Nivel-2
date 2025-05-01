using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboColumna.Items.Add("Codigo");
            cboColumna.Items.Add("Nombre");
            cboColumna.Items.Add("Precio");
            cboColumna.Items.Add("Marca");
            cboColumna.Items.Add("Categoria");
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
                cargarImagen(listaArticulos[0].UrlImagen);
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
                cargarImagen(seleccionado.UrlImagen);
            }
        }
      
        private void cargarImagen(string imagen)
        {
            try
            {
                pcbCatalogo.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbCatalogo.Load("https://glomastore.s3.amazonaws.com/img/sin_imagen.png");
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
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmArticuloAlta modificar = new frmArticuloAlta();
            modificar.ShowDialog();
            cargar();
        }

        private void Eliminar(bool bandera = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea enviar este elemento a la papelera?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    if (bandera)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if(filtro.Length >= 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Cod.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
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

                string campo = cboColumna.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtBusqFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                //dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";
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
                if (!(soloNumeros(txtBusqFiltro.Text)))
                {
                    MessageBox.Show("Ingrese un valor numerico");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void cboColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboColumna.SelectedItem.ToString();
            if(opcion == "Codigo" || opcion == "Nombre" || opcion == "Marca" || opcion == "Categoria")
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
