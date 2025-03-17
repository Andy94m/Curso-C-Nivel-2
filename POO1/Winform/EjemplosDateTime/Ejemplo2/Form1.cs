namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDaytimepicker_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("La fecha selecciona es: " + dtpFecha.Value.ToString("dddd dd MMM yyyy"));
            DateTime fecha1;
            fecha1 = dtpFecha.Value;
            MessageBox.Show("La fecha selecciona es: " + fecha1.ToString("dddd dd MMM yyyy"));
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha selecciona es: " + calFecha.SelectionRange);
        }
    }
}
