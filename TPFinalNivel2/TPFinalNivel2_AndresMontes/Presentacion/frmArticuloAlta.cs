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

        public frmArticuloAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }
        public frmArticuloAlta()
        {
            InitializeComponent();
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

                    txtCod.Text = articulo.Cod.ToString();
                    txtNom.Text = articulo.Nombre.ToString();
                    txtDesc.Text = articulo.Descripcion.ToString();
                    cboMarca.SelectedValue = articulo.Compania.Id.ToString();
                    cboCategoria.SelectedValue = articulo.Tipo.Id.ToString();
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
            cargarImagen(txtImg.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbAgregar.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbAgregar.Load("https://glomastore.s3.amazonaws.com/img/sin_imagen.png");
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "*.jpg;*.jpeg;*.png;*.gif;*.ico;*.webp";
            if (archivo.ShowDialog() == DialogResult.OK) 
            {
                txtImg.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private bool validarAlta()
        {
            if(txtCod.Text == "")
            {
                MessageBox.Show("Ingrese un codigo");
            }

            if(txtNom.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                return true;
            }

            if(txtPrecio.Text != "")
            {
                if (!(soloNumerosAlta(txtPrecio.Text)))
                {
                    MessageBox.Show("Ingrese solo valores numericos");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumerosAlta(string cantidad)
        {
            foreach(char caracter in cantidad)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }

            return true;
        }
    }
}
