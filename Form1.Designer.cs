namespace primeraAplicacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            btnSingletonImpresora = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(64, 86);
            button1.Name = "button1";
            button1.Size = new Size(206, 23);
            button1.TabIndex = 0;
            button1.Text = "Caso 1 Conversion en grados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(64, 126);
            button2.Name = "button2";
            button2.Size = new Size(206, 23);
            button2.TabIndex = 1;
            button2.Text = "Pago Estacionamiento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(64, 166);
            button3.Name = "button3";
            button3.Size = new Size(206, 23);
            button3.TabIndex = 2;
            button3.Text = "Cuenta Bancaria";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 49);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // btnSingletonImpresora
            // 
            btnSingletonImpresora.Location = new Point(64, 228);
            btnSingletonImpresora.Name = "btnSingletonImpresora";
            btnSingletonImpresora.Size = new Size(206, 23);
            btnSingletonImpresora.TabIndex = 4;
            btnSingletonImpresora.Text = "Singleton Impresora";
            btnSingletonImpresora.UseVisualStyleBackColor = true;
            btnSingletonImpresora.Click += btnSingletonImpresora_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSingletonImpresora);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button btnSingletonImpresora;
    }
}