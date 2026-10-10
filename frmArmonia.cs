using LibreriaPuenteMetafisicaADA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YOSoyFilosofiaPsicologiaGardner
{
    public partial class frmArmonia : Form
    {
        public frmArmonia()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            lblevaluando.Visible = true;

            txtsalida.Text = "";

            string saux, saux_punto;

            StringBuilder sb = new StringBuilder();

            // VALORES

            saux = textBox1.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox2.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox3.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox4.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox5.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox6.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox7.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox8.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = textBox9.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            string rutaIn = DatosConfig.AppPath + "fich9.txt";
            File.WriteAllText(rutaIn, sb.ToString());

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico5(DatosConfig.AppPath,
            "fich9.txt", "fich10.txt", out bok);

            if (bok)
            {
                txtsalida.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 5 ADA.");
            }

            lblevaluando.Visible = false;

        }
    }
}
