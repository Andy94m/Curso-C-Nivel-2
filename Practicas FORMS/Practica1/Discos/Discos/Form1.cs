﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Discos
{
    public partial class Form1 : Form
    {
        private List<Album> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dgvAlbum_SelectionChanged(object sender, EventArgs e)
        {
            Album seleccionado = (Album)dgvAlbum.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargar()
        {
            AlbumNegocio negocio = new AlbumNegocio();
            try
            {
                listaDiscos = negocio.listar();
                dgvAlbum.DataSource= listaDiscos;
                dgvAlbum.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaDiscos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaAlbum alta = new frmAltaAlbum();
            alta.ShowDialog();
            cargar();
        }
    }
}
