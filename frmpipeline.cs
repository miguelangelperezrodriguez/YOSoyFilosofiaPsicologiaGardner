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
    public partial class frmpipeline : Form
    {
        public frmpipeline()
        {
            InitializeComponent();
        }

        private void btnejecutar_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de texto
            txtresultado.Text = "";

            // Ejecutamos programa ADA
            bool bok;


            string dato_a_escribir = txtnrozonas.Text;

            // Construimos ruta de fich1 donde guardar selecciones
            string rutaIn = DatosConfig.AppPath + "pipeline.txt";

            File.WriteAllText(rutaIn, dato_a_escribir);

            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaAPipeline(DatosConfig.AppPath,
            "salida_espiritual.txt", out bok);

            if (bok)
            {
                txtresultado.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 10 ADA.");
            }

        }
    }
}
