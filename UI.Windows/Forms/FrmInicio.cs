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
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto= new FrmProducto(); 
            frmProducto.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            frmPedido.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            FrmDetallePedido frmDetallePedido = new FrmDetallePedido();
            frmDetallePedido.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
