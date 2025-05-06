using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Drawing.Text;

namespace Presentacion
{
    public partial class frmArticuloAlta : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        Validaciones validar = new Validaciones();

        public frmArticuloAlta()
        {
            InitializeComponent();
        }

        public frmArticuloAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }
        private void frmArticuloAlta_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            

            try
            {
                cboMarca.DataSource = marcasNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriasNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    Console.Write(cboCategoria.Text);
                    Console.WriteLine(cboMarca.Text);
                    txtCod.Text = articulo.Cod.ToString();
                    txtNom.Text = articulo.Nombre.ToString();
                    txtDesc.Text = articulo.Descripcion.ToString();
                    cboMarca.SelectedValue = articulo.Compania.Id;
                    cboCategoria.SelectedValue = articulo.Tipo.Id;
                    txtImg.Text = articulo.UrlImagen.ToString();
                    txtPrecio.Text = articulo.Precio.ToString();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                if (validarAlta())
                    return;

                articulo.Cod = txtCod.Text;
                articulo.Nombre = txtNom.Text;
                articulo.Descripcion = txtDesc.Text;
                articulo.Compania = (Marcas)cboMarca.SelectedItem;
                articulo.Tipo = (Categorias)cboCategoria.SelectedItem;
                articulo.UrlImagen = (txtImg.Text);
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtImg.Text.ToUpper().Contains("HTTPS")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImg_Leave(object sender, EventArgs e)
        {
            validar.cargarImagen(pcbAgregar, txtImg.Text);
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "*.jpg;*.jpeg;*.png;*.gif;*.ico;*.webp";
            if (archivo.ShowDialog() == DialogResult.OK) 
            {
                txtImg.Text = archivo.FileName;
                //cargarImagen(archivo.FileName);
                validar.cargarImagen(pcbAgregar, archivo.FileName);
            }
        }

        private bool validarAlta()
        {
            if(txtCod.Text == "")
            {
                MessageBox.Show("Ingrese un codigo");
                return true;
            }

            if(txtNom.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return true;
            }

            if(txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese solo valores numericos");
                return true;
            }
            return false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
