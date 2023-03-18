namespace primeraAplicacion
{
    partial class cuentaBancaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCuenta = new Label();
            lblDatosCuenta = new Label();
            btnDeposito = new Button();
            btnRetiro = new Button();
            txtMonto = new TextBox();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Location = new Point(146, 29);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(78, 15);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "Datos Cuenta";
            // 
            // lblDatosCuenta
            // 
            lblDatosCuenta.AutoSize = true;
            lblDatosCuenta.Location = new Point(238, 28);
            lblDatosCuenta.Name = "lblDatosCuenta";
            lblDatosCuenta.Size = new Size(36, 15);
            lblDatosCuenta.TabIndex = 1;
            lblDatosCuenta.Text = "Saldo";
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(149, 66);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(75, 23);
            btnDeposito.TabIndex = 2;
            btnDeposito.Text = "Deposito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // btnRetiro
            // 
            btnRetiro.Location = new Point(149, 112);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(75, 23);
            btnRetiro.TabIndex = 3;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(32, 66);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 4;
            // 
            // cuentaBancaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMonto);
            Controls.Add(btnRetiro);
            Controls.Add(btnDeposito);
            Controls.Add(lblDatosCuenta);
            Controls.Add(lblCuenta);
            Name = "cuentaBancaria";
            Text = "cuentaBancaria";
            Load += cuentaBancaria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Label lblDatosCuenta;
        private Button btnDeposito;
        private Button btnRetiro;
        private TextBox txtMonto;
    }
}