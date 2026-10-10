namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class frmpipeline
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
            btnejecutar = new Button();
            panel2 = new Panel();
            txtresultado = new TextBox();
            label1 = new Label();
            txtnrozonas = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(txtnrozonas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnejecutar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 50);
            panel1.TabIndex = 0;
            // 
            // btnejecutar
            // 
            btnejecutar.Location = new Point(206, 12);
            btnejecutar.Name = "btnejecutar";
            btnejecutar.Size = new Size(134, 23);
            btnejecutar.TabIndex = 0;
            btnejecutar.Text = "Ejecutar";
            btnejecutar.UseVisualStyleBackColor = true;
            btnejecutar.Click += btnejecutar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtresultado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 400);
            panel2.TabIndex = 1;
            // 
            // txtresultado
            // 
            txtresultado.Dock = DockStyle.Fill;
            txtresultado.Location = new Point(0, 0);
            txtresultado.Multiline = true;
            txtresultado.Name = "txtresultado";
            txtresultado.ScrollBars = ScrollBars.Both;
            txtresultado.Size = new Size(566, 400);
            txtresultado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Nro. zonas :";
            // 
            // txtnrozonas
            // 
            txtnrozonas.Location = new Point(87, 13);
            txtnrozonas.Name = "txtnrozonas";
            txtnrozonas.Size = new Size(100, 23);
            txtnrozonas.TabIndex = 2;
            txtnrozonas.Text = "5";
            // 
            // frmpipeline
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmpipeline";
            Text = "frmpipeline";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnejecutar;
        private Panel panel2;
        private TextBox txtresultado;
        private TextBox txtnrozonas;
        private Label label1;
    }
}