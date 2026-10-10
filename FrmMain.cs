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

        private void sexoYinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmying frm = new frmying();
            frm.ShowDialog();
        }

        private void aceptaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlibrealbedrio frm = new frmlibrealbedrio();
            frm.ShowDialog();
        }

        private void poderEnElMundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoder frm = new frmPoder();
            frm.ShowDialog();
        }

        private void leySupremaDeLaArmoníaPerfectaChakrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArmonia frm = new frmArmonia();
            frm.ShowDialog();
        }

        private void borradoDeCristalizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmborradoCristalizaciones frm = new frmborradoCristalizaciones();
            frm.ShowDialog();
        }

        private void metanoiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtratamiento frm = new frmtratamiento();
            frm.ShowDialog();
        }

        private void reglasCorrespondenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreglascorrespondencia frm = new frmreglascorrespondencia();
            frm.ShowDialog();
        }

        private void leyDeRitmoRecaídasMentalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecaidasmentales frm = new frmrecaidasmentales();
            frm.ShowDialog();
        }

        private void pipelinePasosTratamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpipeline frm = new frmpipeline();
            frm.ShowDialog();
        }

        private void amorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmamor frm = new frmamor();
            frm.ShowDialog();

        }
    }
}
