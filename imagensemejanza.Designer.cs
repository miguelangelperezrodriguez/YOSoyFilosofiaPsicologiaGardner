namespace YOSoyFilosofiaPsicologiaGardner
{
    partial class imagensemejanza
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
            groupBox2 = new GroupBox();
            lblprocesando = new Label();
            btnprocesar = new Button();
            lblintensidadpensamiento = new Label();
            trackintensidadpensamiento = new TrackBar();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblenfoqueminimo = new Label();
            trackenfoqueminimo = new TrackBar();
            label3 = new Label();
            lblumbralfirmeza = new Label();
            label1 = new Label();
            trackfirmeza = new TrackBar();
            panel2 = new Panel();
            txtresultado = new TextBox();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackintensidadpensamiento).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackenfoqueminimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackfirmeza).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 139);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(lblprocesando);
            groupBox2.Controls.Add(btnprocesar);
            groupBox2.Controls.Add(lblintensidadpensamiento);
            groupBox2.Controls.Add(trackintensidadpensamiento);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(346, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 139);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Semejanza";
            // 
            // lblprocesando
            // 
            lblprocesando.AutoSize = true;
            lblprocesando.Font = new Font("Segoe UI", 12F);
            lblprocesando.Location = new Point(166, 90);
            lblprocesando.Name = "lblprocesando";
            lblprocesando.Size = new Size(100, 21);
            lblprocesando.TabIndex = 8;
            lblprocesando.Text = "Procesando...";
            lblprocesando.Visible = false;
            // 
            // btnprocesar
            // 
            btnprocesar.Location = new Point(18, 83);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(120, 28);
            btnprocesar.TabIndex = 7;
            btnprocesar.Text = "Procesar";
            btnprocesar.UseVisualStyleBackColor = true;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // lblintensidadpensamiento
            // 
            lblintensidadpensamiento.AutoSize = true;
            lblintensidadpensamiento.Location = new Point(323, 33);
            lblintensidadpensamiento.Name = "lblintensidadpensamiento";
            lblintensidadpensamiento.Size = new Size(22, 15);
            lblintensidadpensamiento.TabIndex = 6;
            lblintensidadpensamiento.Text = "0.0";
            // 
            // trackintensidadpensamiento
            // 
            trackintensidadpensamiento.Location = new Point(199, 33);
            trackintensidadpensamiento.Maximum = 20;
            trackintensidadpensamiento.Name = "trackintensidadpensamiento";
            trackintensidadpensamiento.Size = new Size(104, 45);
            trackintensidadpensamiento.TabIndex = 5;
            trackintensidadpensamiento.ValueChanged += trackintensidadpensamiento_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 4;
            label2.Text = "Intensidad pensamiento (0.0 a 1.0)";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(lblenfoqueminimo);
            groupBox1.Controls.Add(trackenfoqueminimo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblumbralfirmeza);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(trackfirmeza);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Imagen";
            // 
            // lblenfoqueminimo
            // 
            lblenfoqueminimo.AutoSize = true;
            lblenfoqueminimo.Location = new Point(286, 83);
            lblenfoqueminimo.Name = "lblenfoqueminimo";
            lblenfoqueminimo.Size = new Size(13, 15);
            lblenfoqueminimo.TabIndex = 5;
            lblenfoqueminimo.Text = "0";
            // 
            // trackenfoqueminimo
            // 
            trackenfoqueminimo.Location = new Point(159, 83);
            trackenfoqueminimo.Name = "trackenfoqueminimo";
            trackenfoqueminimo.Size = new Size(104, 45);
            trackenfoqueminimo.TabIndex = 4;
            trackenfoqueminimo.ValueChanged += trackenfoqueminimo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 3;
            label3.Text = "Duración enfoque";
            // 
            // lblumbralfirmeza
            // 
            lblumbralfirmeza.AutoSize = true;
            lblumbralfirmeza.Location = new Point(286, 33);
            lblumbralfirmeza.Name = "lblumbralfirmeza";
            lblumbralfirmeza.Size = new Size(22, 15);
            lblumbralfirmeza.TabIndex = 2;
            lblumbralfirmeza.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 1;
            label1.Text = "Umbral firmeza (0.0 a 1.0)";
            // 
            // trackfirmeza
            // 
            trackfirmeza.Location = new Point(159, 35);
            trackfirmeza.Maximum = 20;
            trackfirmeza.Name = "trackfirmeza";
            trackfirmeza.Size = new Size(104, 45);
            trackfirmeza.TabIndex = 0;
            trackfirmeza.ValueChanged += trackfirmeza_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtresultado);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 311);
            panel2.TabIndex = 1;
            // 
            // txtresultado
            // 
            txtresultado.Dock = DockStyle.Fill;
            txtresultado.Location = new Point(0, 0);
            txtresultado.Multiline = true;
            txtresultado.Name = "txtresultado";
            txtresultado.Size = new Size(718, 311);
            txtresultado.TabIndex = 0;
            // 
            // imagensemejanza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "imagensemejanza";
            Text = "imagensemejanza";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackintensidadpensamiento).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackenfoqueminimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackfirmeza).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label lblumbralfirmeza;
        private Label label1;
        private TrackBar trackfirmeza;
        private TrackBar trackenfoqueminimo;
        private Label label3;
        private Button btnprocesar;
        private Label lblintensidadpensamiento;
        private TrackBar trackintensidadpensamiento;
        private Label label2;
        private Label lblenfoqueminimo;
        private TextBox txtresultado;
        private Label lblprocesando;
    }
}