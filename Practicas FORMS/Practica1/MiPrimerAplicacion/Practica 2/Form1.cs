using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPruebaRun_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento click", " WARNING ");
            this.BackColor = Color.White;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo", "ATENCION");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho", "ATENCION");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio", "ATENCION");
        }
    }
}
