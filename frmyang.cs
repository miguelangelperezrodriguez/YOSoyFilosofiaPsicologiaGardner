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
    public partial class frmyang : Form
    {

        CListaAlquimiaYang objAlquimiaYang;

        public frmyang()
        {
            InitializeComponent();

            objAlquimiaYang = new CListaAlquimiaYang();
            actualizarSalida();

        }

        private void actualizarSalida()
        {
            // Mostramos los valores por defecto en Memo.
            txtyang.Text = objAlquimiaYang.RecorrerMostrarLista();

        }

        private void chktipoentrada_CheckedChanged(object sender, EventArgs e)
        {
            chktipoentrada.Text = chktipoentrada.Checked ? "Muerte" : "Vida";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            if (float.TryParse(txtvalor.Text, out float valor) && txtnombre.TextLength > 0)
            {
                if (chktipoentrada.Text == "Vida")
                {
                    objAlquimiaYang.InsertarVida(txtnombre.Text, valor);
                }
                else
                {
                    objAlquimiaYang.InsertarMuerte(txtnombre.Text, valor);
                }
                actualizarSalida();

            }
            else
            {
                return;
            }
        }

        private void chkPlaneta_CheckedChanged(object sender, EventArgs e)
        {
            chkPlaneta.Text = chkPlaneta.Checked ? "Planeta2" : "Planeta1";
        }

        private void btnaddplaneta_Click(object sender, EventArgs e)
        {
            // Tomamos los valores del formulario
            if (float.TryParse(txtvalorplaneta.Text, out float valor) && txtnombreplaneta.TextLength > 0)
            {
                if (chkPlaneta.Text == "Planeta1")
                {
                    objAlquimiaYang.InsertarPlaneta(1, txtnombreplaneta.Text, valor);
                }
                else
                {
                    objAlquimiaYang.InsertarPlaneta(2, txtnombreplaneta.Text, valor);
                }
                actualizarSalida();

            }
            else
            {
                return;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtvalorupdate.Text, out float valor) && txtnombreupdate.TextLength > 0)
            {
                var res = objAlquimiaYang.BuscarNombre(txtnombreupdate.Text);
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
