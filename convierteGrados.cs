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
    public partial class convierteGrados : Form
    {
        public convierteGrados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double gradosC = 0;
            double gradosF = 0;

            gradosC = Convert.ToDouble(txtGradosC.Text);
            gradosF = (gradosC * 1.8) + 32;
            txtGradosF.Text = gradosF.ToString();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
