using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeraAplicacion
{
    public partial class pagoEstacionamiento : Form
    {
        public pagoEstacionamiento()
        {
            InitializeComponent();
        }

        private void pagoEstacionamiento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bnCalcular_Click(object sender, EventArgs e)
        {
            dtpSalida.Value = DateTime.Now;
            int minutos = 0;
            int horas = 0;
            double pago = 2.5;
            minutos = Convert.ToInt32((dtpSalida.Value - dtpIngreso.Value).TotalMinutes);
            horas = Convert.ToInt32(minutos / 60);
            minutos = minutos - horas * 60;
            if (minutos > 0)
            {
                horas = horas + 1;

            }
            lblHorasTotales.Text = horas.ToString();
            txtPago.Text = (pago * horas).ToString("N2");
        }
    }
}
