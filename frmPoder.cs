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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YOSoyFilosofiaPsicologiaGardner
{
    public partial class frmPoder : Form
    {
        public frmPoder()
        {
            InitializeComponent();
        }

        private void btnevaluar_Click(object sender, EventArgs e)
        {
            txtsalida.Text = "";

            string saux, saux_punto;

            StringBuilder sb = new StringBuilder();

            // VALORES

            saux = txtideaabstracta.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtMiedo.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtprocrastinar.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtFe.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtprototipo.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtproducto.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            // ENLACES

            saux = txtinicio_duda.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtduda_procrastina.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtprocrastina_meta.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtInicio_AltaVibracion.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtAltaVibracion_Programar.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            saux = txtprogramacion_Meta.Text;
            saux_punto = saux.Replace(",", ".");
            sb.AppendLine(saux_punto);

            string rutaIn = DatosConfig.AppPath + "fich7.txt";
            File.WriteAllText(rutaIn, sb.ToString());

            bool bok;
            // Conectamos con programa cristianismodinamico1.
            DatosConfig.bufferTexto = PuenteMetafisicaADA.LlamadaACristianismoDinamico4(DatosConfig.AppPath,
            "fich7.txt", "fich8.txt", out bok);

            if (bok)
            {
                txtsalida.Text = DatosConfig.bufferTexto;
            }
            else
            {
                MessageBox.Show("Error al conectar con programa 4 ADA.");
            }
        }

    }

}
