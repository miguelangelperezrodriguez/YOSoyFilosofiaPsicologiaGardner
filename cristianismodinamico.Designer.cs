namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class cristianismodinamico
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
            panel1 = new Panel();
            btnEvaluar = new Button();
            chkEnfoqueContinuo = new CheckBox();
            chkPensamientoFirme = new CheckBox();
            panel2 = new Panel();
            txtResultado = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(btnEvaluar);
            panel1.Controls.Add(chkEnfoqueContinuo);
            panel1.Controls.Add(chkPensamientoFirme);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 49);
            panel1.TabIndex = 0;
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(334, 12);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(82, 25);
            btnEvaluar.TabIndex = 2;
            btnEvaluar.Text = "Evaluar";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // chkEnfoqueContinuo
            // 
            chkEnfoqueContinuo.AutoSize = true;
            chkEnfoqueContinuo.Location = new Point(161, 15);
            chkEnfoqueContinuo.Name = "chkEnfoqueContinuo";
            chkEnfoqueContinuo.Size = new Size(121, 19);
            chkEnfoqueContinuo.TabIndex = 1;
            chkEnfoqueContinuo.Text = "Enfoque continuo";
            chkEnfoqueContinuo.UseVisualStyleBackColor = true;
            // 
            // chkPensamientoFirme
            // 
            chkPensamientoFirme.AutoSize = true;
            chkPensamientoFirme.Location = new Point(29, 15);
            chkPensamientoFirme.Name = "chkPensamientoFirme";
            chkPensamientoFirme.Size = new Size(126, 19);
            chkPensamientoFirme.TabIndex = 0;
            chkPensamientoFirme.Text = "Pensamiento firme";
            chkPensamientoFirme.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(txtResultado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 200);
            panel2.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Dock = DockStyle.Fill;
            txtResultado.Location = new Point(0, 0);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(501, 200);
            txtResultado.TabIndex = 0;
            // 
            // cristianismodinamico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 249);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "cristianismodinamico";
            Text = "cristianismodinamico";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox chkEnfoqueContinuo;
        private CheckBox chkPensamientoFirme;
        private Panel panel2;
        private Button btnEvaluar;
        private TextBox txtResultado;
    }
}