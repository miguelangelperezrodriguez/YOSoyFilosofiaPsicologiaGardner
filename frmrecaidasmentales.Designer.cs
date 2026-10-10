namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class frmrecaidasmentales
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
            btnaplicar = new Button();
            cmbnegativo = new ComboBox();
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
            panel1.Controls.Add(btnaplicar);
            panel1.Controls.Add(cmbnegativo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 61);
            panel1.TabIndex = 0;
            // 
            // btnaplicar
            // 
            btnaplicar.Location = new Point(425, 20);
            btnaplicar.Name = "btnaplicar";
            btnaplicar.Size = new Size(75, 23);
            btnaplicar.TabIndex = 2;
            btnaplicar.Text = "Aplicar";
            btnaplicar.UseVisualStyleBackColor = true;
            btnaplicar.Click += btnaplicar_Click;
            // 
            // cmbnegativo
            // 
            cmbnegativo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnegativo.FormattingEnabled = true;
            cmbnegativo.Items.AddRange(new object[] { "Escasez de Creencia", "Miedo a la enfermedad", "Rencor y resentimiento" });
            cmbnegativo.Location = new Point(188, 20);
            cmbnegativo.Name = "cmbnegativo";
            cmbnegativo.Size = new Size(222, 23);
            cmbnegativo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Pensamientos Negativos";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtresultado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 389);
            panel2.TabIndex = 1;
            // 
            // txtresultado
            // 
            txtresultado.Dock = DockStyle.Fill;
            txtresultado.Location = new Point(0, 0);
            txtresultado.Multiline = true;
            txtresultado.Name = "txtresultado";
            txtresultado.ScrollBars = ScrollBars.Vertical;
            txtresultado.Size = new Size(800, 389);
            txtresultado.TabIndex = 0;
            // 
            // frmrecaidasmentales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmrecaidasmentales";
            Text = "frmrecaidasmentales";
            Load += frmrecaidasmentales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbnegativo;
        private Label label1;
        private Button btnaplicar;
        private Panel panel2;
        private TextBox txtresultado;
    }
}