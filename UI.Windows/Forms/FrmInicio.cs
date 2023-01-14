using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Windows.Forms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FrmTipoTransaccion frmtipoTransaccion = new FrmTipoTransaccion();
            frmtipoTransaccion.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FrmIngresoEgreso frmIngresoEgreso = new FrmIngresoEgreso();
            frmIngresoEgreso.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FrmDetalleIngreso frmDetalleIngreso = new FrmDetalleIngreso();
            frmDetalleIngreso.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
