using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Validaciones
    {


        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void NoSimbol(KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void cargarImagen(PictureBox pcbImagen, string imagen)
        {
            try
            {
                pcbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pcbImagen.Load("https://glomastore.s3.amazonaws.com/img/sin_imagen.png");
            }
        }
    }
}

