namespace primeraAplicacion
{
    partial class convierteGrados
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
            btnConvertir = new Button();
            lblCelcius = new Label();
            txtGradosC = new TextBox();
            txtGradosF = new TextBox();
            lblFarenheit = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(275, 30);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(97, 23);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convierte A";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblCelcius
            // 
            lblCelcius.AutoSize = true;
            lblCelcius.Location = new Point(201, 33);
            lblCelcius.Name = "lblCelcius";
            lblCelcius.Size = new Size(45, 15);
            lblCelcius.TabIndex = 1;
            lblCelcius.Text = "Celcius";
            lblCelcius.Click += label1_Click;
            // 
            // txtGradosC
            // 
            txtGradosC.Location = new Point(68, 30);
            txtGradosC.Name = "txtGradosC";
            txtGradosC.Size = new Size(100, 23);
            txtGradosC.TabIndex = 2;
            txtGradosC.TextChanged += textBox1_TextChanged;
            // 
            // txtGradosF
            // 
            txtGradosF.Location = new Point(396, 30);
            txtGradosF.Name = "txtGradosF";
            txtGradosF.Size = new Size(100, 23);
            txtGradosF.TabIndex = 3;
            // 
            // lblFarenheit
            // 
            lblFarenheit.AutoSize = true;
            lblFarenheit.Location = new Point(528, 33);
            lblFarenheit.Name = "lblFarenheit";
            lblFarenheit.Size = new Size(56, 15);
            lblFarenheit.TabIndex = 4;
            lblFarenheit.Text = "Farenheit";
            lblFarenheit.Click += label2_Click;
            // 
            // convierteGrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFarenheit);
            Controls.Add(txtGradosF);
            Controls.Add(txtGradosC);
            Controls.Add(lblCelcius);
            Controls.Add(btnConvertir);
            Name = "convierteGrados";
            Text = "convierteGrados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private Label lblCelcius;
        private TextBox txtGradosC;
        private TextBox txtGradosF;
        private Label lblFarenheit;
    }
}