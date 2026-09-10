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
    public partial class frmlibrealbedrio : Form
    {
        public frmlibrealbedrio()
        {
            InitializeComponent();
        }

        private void CalcularSumaMedia()
        {
            float v1, v2, v3, v4, v5;
            float media;
            float suma;

            if (!(float.TryParse(textBox1.Text,out v1)))
            {
                MessageBox.Show("Valores no correctos");
                return;
            }
            if (!(float.TryParse(textBox2.Text, out v2)))
            {
                MessageBox.Show("Valores no correctos");
                return;
            }
            if (!(float.TryParse(textBox3.Text, out v3)))
            {
                MessageBox.Show("Valores no correctos");
                return;
            }
            if (!(float.TryParse(textBox4.Text, out v4)))
            {
                MessageBox.Show("Valores no correctos");
                return;
            }
            if (!(float.TryParse(textBox5.Text, out v5)))
            {
                MessageBox.Show("Valores no correctos");
                return;
            }

            suma = v1 + v2 + v3 + v4 + v5;
            txtsuma.Text = suma.ToString();

            media = suma / 5;
            txtmedia.Text = media.ToString();

        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            txtsalida.Text = "";

            // Simulación es con valor 0 en la caja
            if (chksimulacion.Checked)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
            }

            string saux,saux_punto;

            StringBuilder sb = new StringBuilder();

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

            string rutaIn = DatosConfig.AppPath + "fich5.txt";
            File.WriteAllText(rutaIn, sb.ToString());

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico3(DatosConfig.AppPath,
            "fich5.txt", "fich6.txt", out bok);

            if (bok)
            {
                txtsalida.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 3 ADA.");
            }

            CalcularSumaMedia();

        }
    }
}
