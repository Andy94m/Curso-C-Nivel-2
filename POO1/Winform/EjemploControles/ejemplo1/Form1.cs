﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;

            //list view funciona como una coleccion:
            lwElementos.Items.Add(elem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;

            //Operador ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";

            string tipo;
            if (rbtMuggle.Checked == true)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + " , su num fav es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + ", Fecha: " + fecha + ", " + mensaje);
        }
    }
}
