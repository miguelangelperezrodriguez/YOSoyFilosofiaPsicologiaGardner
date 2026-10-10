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
    public partial class frmborradoCristalizaciones : Form
    {
        public frmborradoCristalizaciones()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            // Convertimos a mayúsculas
            txtfrase.Text = txtfrase.Text.ToUpper();

            string rutaIn = DatosConfig.AppPath + "fich11.txt";
            File.WriteAllText(rutaIn, txtfrase.Text);

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico6(DatosConfig.AppPath,
            "fich11.txt", "fich12.txt", out bok);

            if (bok)
            {
                txtsalida.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 6 ADA.");
            }

        }
    }
}
