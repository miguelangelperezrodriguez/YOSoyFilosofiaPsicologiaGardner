namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class frmreglascorrespondencia
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
            cmbpensamiento = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            txtresultado = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cmbpensamiento);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 62);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(383, 22);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 2;
            button1.Text = "Aplicar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbpensamiento
            // 
            cmbpensamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpensamiento.FormattingEnabled = true;
            cmbpensamiento.Items.AddRange(new object[] { "Escasez de Creencia", "Miedo a la Enfermedad", "Rencor y Resentimiento", "Ansiedad por el Futuro" });
            cmbpensamiento.Location = new Point(185, 23);
            cmbpensamiento.Name = "cmbpensamiento";
            cmbpensamiento.Size = new Size(170, 23);
            cmbpensamiento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Pensamiento negativo";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtresultado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 388);
            panel2.TabIndex = 1;
            // 
            // txtresultado
            // 
            txtresultado.Dock = DockStyle.Fill;
            txtresultado.Location = new Point(0, 0);
            txtresultado.Multiline = true;
            txtresultado.Name = "txtresultado";
            txtresultado.ScrollBars = ScrollBars.Vertical;
            txtresultado.Size = new Size(683, 388);
            txtresultado.TabIndex = 0;
            // 
            // frmreglascorrespondencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmreglascorrespondencia";
            Text = "frmreglascorrespondencia";
            Load += frmreglascorrespondencia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbpensamiento;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TextBox txtresultado;
    }
}