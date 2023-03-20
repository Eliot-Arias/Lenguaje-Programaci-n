namespace primeraAplicacion
{
    partial class Impresiones
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
            cmbUsuario = new ComboBox();
            btnImprimir = new Button();
            txtLog = new TextBox();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Items.AddRange(new object[] { "Juan", "María", "Pedro" });
            cmbUsuario.Location = new Point(12, 31);
            cmbUsuario.Name = "lblCuenta";
            cmbUsuario.Size = new Size(142, 23);
            cmbUsuario.TabIndex = 0;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(183, 31);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(97, 23);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 70);
            txtLog.Multiline = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(268, 187);
            txtLog.TabIndex = 2;
            // 
            // Impresiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 363);
            Controls.Add(txtLog);
            Controls.Add(btnImprimir);
            Controls.Add(cmbUsuario);
            Name = "Impresiones";
            Text = "Impresiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUsuario;
        private Button btnImprimir;
        private TextBox txtLog;
    }
}