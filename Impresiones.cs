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
    public partial class Impresiones : Form
    {
        public Impresiones()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text != "")
            {
                clsImpresora imp = clsImpresora.GetImpresora();
                txtLog.Text = txtLog.Text + imp.print(cmbUsuario.Text);
            }
        }
    }
}
