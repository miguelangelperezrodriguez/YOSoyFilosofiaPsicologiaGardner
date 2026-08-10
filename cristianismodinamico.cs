using LibreriaPuenteMetafisicaADA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace YOSoyFilosofiaPsicologiaGardner
{
    public partial class cristianismodinamico : Form
    {
        public cristianismodinamico()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            // Construimos ruta de fich1 donde guardar selecciones
            string rutaIn = DatosConfig.AppPath + "fich1.txt";
            StringBuilder sb = new StringBuilder();

            string strInsertar = chkPensamientoFirme.Checked ? "SI" : "NO";
            sb.AppendLine(strInsertar);
            strInsertar = chkEnfoqueContinuo.Checked ? "SI" : "NO";
            sb.AppendLine(strInsertar);

            System.IO.File.WriteAllText(rutaIn,sb.ToString());

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico1(DatosConfig.AppPath,
            "fich1.txt", "fich2.txt",out bok);
            if (bok) {
                txtResultado.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 1 ADA.");
            }
        }
    }
}
