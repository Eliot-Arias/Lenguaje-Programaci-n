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
    public partial class cuentaBancaria : Form
    {
        private clsCuentaBancaria objCuentaBancaria;
        public cuentaBancaria()
        {
            InitializeComponent();
        }

        private void cuentaBancaria_Load(object sender, EventArgs e)
        {
            objCuentaBancaria = new clsCuentaBancaria("Jhon", "Doe", 2000, "calle 1", "");
            lblDatosCuenta.Text = objCuentaBancaria.ToString();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                objCuentaBancaria.Depositos(Convert.ToDouble(txtMonto.Text));
                lblDatosCuenta.Text = objCuentaBancaria.ToString();
                txtMonto.Text = "";
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                if (Convert.ToDouble(txtMonto.Text) < objCuentaBancaria.ConsultaSaldo())
                {
                    objCuentaBancaria.retiro(Convert.ToDouble(txtMonto.Text));
                    lblDatosCuenta.Text = objCuentaBancaria.ToString();
                }
                else
                {
                    MessageBox.Show("No dispone de saldo suficiente!");
                }
                txtMonto.Text = "";
            }
        }
    }
}
