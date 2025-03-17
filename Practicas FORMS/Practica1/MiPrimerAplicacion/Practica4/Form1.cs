using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPUM_Click(object sender, EventArgs e)
        {
            if(txbPrincipal.Text == "")
                txbPrincipal.BackColor = Color.Red;
            else
                txbPrincipal.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbSecundario_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txbSecundario.Text.Length + " caracteres");
        }
    }
}
