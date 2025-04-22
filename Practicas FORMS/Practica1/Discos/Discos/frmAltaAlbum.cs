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
using System.IO;
using System.Configuration;

namespace Discos
{
    public partial class frmAltaAlbum : Form
    {
        private Album disco = null;
        private OpenFileDialog archivo = null;
        public frmAltaAlbum()
        {
            InitializeComponent();
        }

        public frmAltaAlbum(Album disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Album";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AlbumNegocio negocio = new AlbumNegocio();

            try
            {
                if(disco == null)
                    disco = new Album();

                if(validarAlta())
                    return;

                disco.Nombre = txtNombre.Text;
                disco.Fecha = dtpFecha.Value;
                disco.Canciones = int.Parse(txtCant.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.Formato = (Edicion)cboEdicion.SelectedItem;
                disco.Genero = (Estilos)cboEstilo.SelectedItem;

                if (disco.Numero != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else 
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado Exitosamente");
                }

                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTPS")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmAltaAlbum_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstilosNegocio estilosNegocio = new EstilosNegocio();

            try
            {
                cboEdicion.DataSource = edicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";

                cboEstilo.DataSource = estilosNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    Console.WriteLine($"Formato.Id: {disco.Formato?.Id}");
                    Console.WriteLine($"Genero.Id: {disco.Genero?.Id}");
                    
                    txtNombre.Text = disco.Nombre.ToString();
                    dtpFecha.Value = disco.Fecha;
                    txtCant.Text = disco.Canciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagen;
                    cboEdicion.SelectedValue = disco.Formato.Id;
                    cboEstilo.SelectedValue = disco.Genero.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private bool validarAlta()
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un titulo");
                return true;
            }

            if(txtCant.Text != "")
            {
                if (!(soloNumerosAlta(txtCant.Text)))
                {
                    MessageBox.Show("Ingrese solo valores numericos");
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor en Cant Canciones");
                return true;
            }

            return false;
        }

        private bool soloNumerosAlta (string cantidad)
        {
            foreach (char caracter in cantidad)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
    }
}
