namespace primeraAplicacion
{
    partial class pagoEstacionamiento
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
            lblIngreso = new Label();
            lblSalida = new Label();
            lblHoras = new Label();
            bnCalcular = new Button();
            lblHorasTotales = new Label();
            txtPago = new TextBox();
            dtpIngreso = new DateTimePicker();
            dtpSalida = new DateTimePicker();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(37, 40);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(46, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Ingreso";
            lblIngreso.Click += label1_Click;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(37, 80);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(38, 15);
            lblSalida.TabIndex = 1;
            lblSalida.Text = "Salida";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Location = new Point(221, 18);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(64, 15);
            lblHoras.TabIndex = 2;
            lblHoras.Text = "(2.5) Horas";
            // 
            // bnCalcular
            // 
            bnCalcular.Location = new Point(221, 36);
            bnCalcular.Name = "bnCalcular";
            bnCalcular.Size = new Size(75, 23);
            bnCalcular.TabIndex = 3;
            bnCalcular.Text = "Calcular";
            bnCalcular.UseVisualStyleBackColor = true;
            bnCalcular.Click += bnCalcular_Click;
            // 
            // lblHorasTotales
            // 
            lblHorasTotales.AutoSize = true;
            lblHorasTotales.Location = new Point(338, 18);
            lblHorasTotales.Name = "lblHorasTotales";
            lblHorasTotales.Size = new Size(12, 15);
            lblHorasTotales.TabIndex = 4;
            lblHorasTotales.Text = "_";
            lblHorasTotales.Click += label4_Click;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(329, 36);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(100, 23);
            txtPago.TabIndex = 5;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Time;
            dtpIngreso.Location = new Point(99, 36);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(104, 23);
            dtpIngreso.TabIndex = 6;
            dtpIngreso.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Time;
            dtpSalida.Location = new Point(99, 74);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(104, 23);
            dtpSalida.TabIndex = 7;
            // 
            // pagoEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpSalida);
            Controls.Add(dtpIngreso);
            Controls.Add(txtPago);
            Controls.Add(lblHorasTotales);
            Controls.Add(bnCalcular);
            Controls.Add(lblHoras);
            Controls.Add(lblSalida);
            Controls.Add(lblIngreso);
            Name = "pagoEstacionamiento";
            Text = "pagoEstacionamiento";
            Load += pagoEstacionamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Label lblSalida;
        private Label lblHoras;
        private Button bnCalcular;
        private Label lblHorasTotales;
        private TextBox txtPago;
        private DateTimePicker dtpIngreso;
        private DateTimePicker dtpSalida;
    }
}