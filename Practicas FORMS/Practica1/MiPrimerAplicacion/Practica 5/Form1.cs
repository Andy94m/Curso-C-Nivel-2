using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool flagApellido = true, flagNombre = true, flagEdad = true, flagDireccion = true;
            string resultado;

            if (txbApellido.Text == "")
            {
                txbApellido.BackColor = Color.Red;
                flagApellido = false;
            }
            else
                txbApellido.BackColor = System.Drawing.SystemColors.Control;


            if (txbNombre.Text == "")
            {
                txbNombre.BackColor = Color.Red;
                flagNombre = false;
            }
            else
                txbNombre.BackColor= System.Drawing.SystemColors.Control;


            if (txbEdad.Text == "")
            {
                txbEdad.BackColor = Color.Red;
                flagEdad = false;
            }
            else
                txbEdad.BackColor = System.Drawing.SystemColors.Control;


            if (txbDireccion.Text == "")
            {
                txbDireccion.BackColor = Color.Red;
                flagDireccion = false;
            }
            else
                txbDireccion.BackColor= System.Drawing.SystemColors.Control;


            if (flagApellido == true && flagNombre == true && flagEdad == true && flagDireccion == true)
            {
                //resultado = (txbApellido.Text txbNombre);
                //txbResultado.Text = txbApellido.Text + txbNombre.Text + txbEdad.Text + txbDireccion.Text; //en esta linea me gustaria añadir los resultados 

                resultado = $"Apellido y Nombre: {txbApellido.Text} {txbNombre.Text} {Environment.NewLine} Edad: {txbEdad.Text} {Environment.NewLine} Dirección: {txbDireccion.Text}";
                txbResultado.Text = resultado;
            }
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}