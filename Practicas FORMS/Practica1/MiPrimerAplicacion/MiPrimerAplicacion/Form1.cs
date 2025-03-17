using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frmPractica : Form
    {
        public frmPractica()
        {
            InitializeComponent();
        }

        private void frmPractica_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmPractica_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }
    }
}
