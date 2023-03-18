namespace primeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new convierteGrados();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new pagoEstacionamiento();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form3 = new cuentaBancaria();
            form3.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}