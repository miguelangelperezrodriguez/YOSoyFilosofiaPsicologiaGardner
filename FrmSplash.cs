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
    public partial class FrmSplash : Form
    {
        private int valortimer = 0;

        public FrmSplash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valortimer = valortimer + 1;
            if (valortimer >= 4)
            {
                timer1.Enabled = false;
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
        }
    }
}
