using LibreriaPuenteMetafisicaADA;

namespace YOSoyFilosofiaPsicologiaGardner
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Almacenamos la ruta del ejecutable.
            DatosConfig.AppPath = AppContext.BaseDirectory;
            statusRuta.Text = DatosConfig.AppPath;

        }

        private void cristianismoDinámicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cristianismodinamico frm = new cristianismodinamico();
            frm.ShowDialog();
        }

        private void imagenSemejanzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagensemejanza frm = new imagensemejanza();
            frm.ShowDialog();
        }

        private void sexoYangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmyang frm = new frmyang();
            frm.ShowDialog();
        }
    }
}
