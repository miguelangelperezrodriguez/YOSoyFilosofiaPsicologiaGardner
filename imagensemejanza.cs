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
    public partial class imagensemejanza : Form
    {
        public imagensemejanza()
        {
            InitializeComponent();
        }

        private void trackfirmeza_ValueChanged(object sender, EventArgs e)
        {
            float fvalor = ((float)trackfirmeza.Value) / 20.0F;
            string svalor = fvalor.ToString();
            lblumbralfirmeza.Text = svalor;
        }

        private void trackenfoqueminimo_ValueChanged(object sender, EventArgs e)
        {
            lblenfoqueminimo.Text = trackenfoqueminimo.Value.ToString();
        }

        private void trackintensidadpensamiento_ValueChanged(object sender, EventArgs e)
        {
            float fvalor = ((float)trackintensidadpensamiento.Value) / 20.0F;
            string svalor = fvalor.ToString();
            lblintensidadpensamiento.Text = svalor;
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de texto
            txtresultado.Text = "";
            lblprocesando.Visible = true;

            // Convertimos valores a validos para ADA
            string sumbralfirmeza = DatosConfig.ConvertirFlotanteADA(lblumbralfirmeza.Text).ToString();
            string stiempoenfoque = Int32.Parse(lblenfoqueminimo.Text).ToString();
            string sintensidadpensamiento = DatosConfig.ConvertirFlotanteADA(lblintensidadpensamiento.Text).ToString();

            // Construimos ruta de fich1 donde guardar selecciones
            string rutaIn = DatosConfig.AppPath + "fich3.txt";
            StringBuilder sb = new StringBuilder();

            string strInsertar = sumbralfirmeza;
            sb.AppendLine(strInsertar);
            strInsertar = stiempoenfoque;
            sb.AppendLine(strInsertar);
            strInsertar = sintensidadpensamiento;
            sb.AppendLine(strInsertar);


            System.IO.File.WriteAllText(rutaIn, sb.ToString());

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico2(DatosConfig.AppPath,
            "fich3.txt", "fich4.txt", out bok);

            lblprocesando.Visible = false;

            if (bok)
            {
                txtresultado.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 1 ADA.");
            }

        }
    }
}
