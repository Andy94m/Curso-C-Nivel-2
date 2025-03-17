using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblPrincipal.BackColor = Color.Cyan;
            lblPrincipal.Cursor = Cursors.Hand;
        }

        private void lblPrincipal_MouseLeave(object sender, EventArgs e)
        {
            lblPrincipal.BackColor = System.Drawing.SystemColors.Control;
            //lblPrincipal.Cursor = Cursors.Default;
        }
    }
}
