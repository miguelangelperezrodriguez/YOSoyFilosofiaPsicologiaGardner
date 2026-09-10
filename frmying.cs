using LibreriasEstructurasAlquimia;
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
    public partial class frmying : Form
    {

        CListaAlquimiaYin objAlquimiaYin;

        public frmying()
        {
            InitializeComponent();
            RellenarElementosCreacion();
        }

        private void RellenarElementosCreacion()
        {
            foreach (var elemento in CListaAlquimiaYin.listaElementos)
            {
                cmbelem1.Items.Add(elemento);
                cmbelem2.Items.Add(elemento);
                cmbelem3.Items.Add(elemento);
            }
            cmbelem1.SelectedIndex = 0;
            cmbelem2.SelectedIndex = 0;
            cmbelem3.SelectedIndex = 0;
        }

        private void actualizarSalida()
        {
            // Mostramos los valores por defecto en Memo.
            txtyin.Text = objAlquimiaYin.RecorrerMostrarLista();

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            TDatoYin t1, t2, t3;
            t1 = CListaAlquimiaYin.TraducirElemento(cmbelem1.Text);
            t2 = CListaAlquimiaYin.TraducirElemento(cmbelem2.Text);
            t3 = CListaAlquimiaYin.TraducirElemento(cmbelem3.Text);

            objAlquimiaYin = new CListaAlquimiaYin(t1, t2, t3);

            actualizarSalida();

        }

        private void chkPlaneta_CheckedChanged(object sender, EventArgs e)
        {
            chkPlaneta.Text = chkPlaneta.Checked ? "PlanetaFire2" : "PlanetaFire1";
        }


        private void btnaddplaneta_Click_1(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            if (float.TryParse(txtvalorplaneta.Text, out float valor) && txtnombreplaneta.TextLength > 0)
            {
                if (chkPlaneta.Text == "PlanetaFire1")
                {
                    objAlquimiaYin.InsertarPlaneta(1, txtnombreplaneta.Text, valor);
                }
                else
                {
                    objAlquimiaYin.InsertarPlaneta(2, txtnombreplaneta.Text, valor);
                }
                actualizarSalida();

            }
            else
            {
                return;
            }
        }

        private void btnaddzodiaco_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            if (float.TryParse(txtvalorzodiaco.Text, out float valor) && txtnombrezodiaco.TextLength > 0)
            {
                objAlquimiaYin.InsertarZodiaco(txtnombrezodiaco.Text, valor);
                actualizarSalida();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtvalorupdate.Text, out float valor) && txtnombreupdate.TextLength > 0)
            {
                var res = objAlquimiaYin.BuscarNombre(txtnombreupdate.Text);
                if (res != null)
                {
                    res.fValor = valor;
                    actualizarSalida();
                }
                else
                {
                    MessageBox.Show("Este nombre no existe.");
                }
            }

        }
    }
}
