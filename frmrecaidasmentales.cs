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
    public partial class frmrecaidasmentales : Form
    {
        public frmrecaidasmentales()
        {
            InitializeComponent();
        }

        private void frmrecaidasmentales_Load(object sender, EventArgs e)
        {
            cmbnegativo.SelectedIndex = 0;
        }

        private void btnaplicar_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de texto
            txtresultado.Text = "";

            string dato_a_escribir = (cmbnegativo.SelectedIndex + 1).ToString();

            // Construimos ruta de fich1 donde guardar selecciones
            string rutaIn = DatosConfig.AppPath + "metafisica5.txt";

            File.WriteAllText(rutaIn, dato_a_escribir);

            // Ejecutamos programa ADA
            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaAMetafisica3(DatosConfig.AppPath,
            "metafisica5.txt", "metafisica6.txt", out bok);

            if (bok)
            {
                txtresultado.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 9 ADA.");
            }

        }
    }
}
