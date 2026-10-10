namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class frmamor
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
            button1 = new Button();
            panel2 = new Panel();
            txtsalida = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 52);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 0;
            button1.Text = "Ejecutar progama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtsalida);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(682, 228);
            panel2.TabIndex = 1;
            // 
            // txtsalida
            // 
            txtsalida.Dock = DockStyle.Fill;
            txtsalida.Location = new Point(0, 0);
            txtsalida.Multiline = true;
            txtsalida.Name = "txtsalida";
            txtsalida.ScrollBars = ScrollBars.Vertical;
            txtsalida.Size = new Size(682, 228);
            txtsalida.TabIndex = 0;
            // 
            // frmamor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 280);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmamor";
            Text = "frmamor";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private TextBox txtsalida;
    }
}