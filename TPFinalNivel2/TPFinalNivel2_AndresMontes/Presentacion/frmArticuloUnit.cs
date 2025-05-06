using Dominio;
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
    public partial class frmArticuloUnit : Form
    {
        private Articulo articulo = null;
        Validaciones validar = new Validaciones();
        public frmArticuloUnit()
        {
            InitializeComponent();
        }

        public frmArticuloUnit (Articulo unitario)
        {
            InitializeComponent();
            this.articulo = unitario;
            Text = "Articulo unidad";
        }

        private void frmArticuloUnit_Load(object sender, EventArgs e)
        {
            lblCodUnit.Text = articulo.Cod;
            lblNombUnit.Text = articulo.Nombre;
            lblDescUnit.Text = articulo.Descripcion;
            lblMarcaUnit.Text = articulo.Compania.Descripcion;
            lblCateUnit.Text = articulo.Tipo.Descripcion;
            lblPricUnit.Text = articulo.Precio.ToString("F2");
            validar.cargarImagen(pcbArtUnit, articulo.UrlImagen);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
