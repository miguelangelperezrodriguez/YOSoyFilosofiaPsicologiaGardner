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
    public partial class frmreglascorrespondencia : Form
    {
        public frmreglascorrespondencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de texto
            txtresultado.Text = "";

            string dato_a_escribir = (cmbpensamiento.SelectedIndex + 1).ToString();

            // Construimos ruta de fich1 donde guardar selecciones
            string rutaIn = DatosConfig.AppPath + "metafisica3.txt";

            File.WriteAllText(rutaIn, dato_a_escribir);

            // Ejecutamos programa ADA
            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaAMetafisica2(DatosConfig.AppPath,
            "metafisica3.txt", "metafisica4.txt", out bok);

            if (bok)
            {
                txtresultado.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 8 ADA.");
            }

        }

        private void frmreglascorrespondencia_Load(object sender, EventArgs e)
        {
            cmbpensamiento.SelectedIndex = 0;
        }
    }
}
