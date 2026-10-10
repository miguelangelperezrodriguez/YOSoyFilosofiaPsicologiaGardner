namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class frmborradoCristalizaciones
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
            txtfrase = new TextBox();
            label1 = new Label();
            btnevaluar = new Button();
            panel2 = new Panel();
            txtsalida = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(btnevaluar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtfrase);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 101);
            panel1.TabIndex = 0;
            // 
            // txtfrase
            // 
            txtfrase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtfrase.Location = new Point(135, 21);
            txtfrase.Name = "txtfrase";
            txtfrase.Size = new Size(653, 23);
            txtfrase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Frase :";
            // 
            // btnevaluar
            // 
            btnevaluar.Location = new Point(39, 59);
            btnevaluar.Name = "btnevaluar";
            btnevaluar.Size = new Size(94, 24);
            btnevaluar.TabIndex = 2;
            btnevaluar.Text = "Evaluar";
            btnevaluar.UseVisualStyleBackColor = true;
            btnevaluar.Click += btnevaluar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtsalida);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 349);
            panel2.TabIndex = 1;
            // 
            // txtsalida
            // 
            txtsalida.Dock = DockStyle.Fill;
            txtsalida.Location = new Point(0, 0);
            txtsalida.Multiline = true;
            txtsalida.Name = "txtsalida";
            txtsalida.ScrollBars = ScrollBars.Vertical;
            txtsalida.Size = new Size(800, 349);
            txtsalida.TabIndex = 0;
            // 
            // frmborradoCristalizaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmborradoCristalizaciones";
            Text = "frmborradoCristalizaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnevaluar;
        private Label label1;
        private TextBox txtfrase;
        private Panel panel2;
        private TextBox txtsalida;
    }
}