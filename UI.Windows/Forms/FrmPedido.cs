using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Windows.AplicationController;
using UI.Windows.ViewModel;

namespace UI.Windows.Forms
{
    public partial class FrmPedido : Form
    {
        private PedidoController pedidoController;
        private PedidoViewModel pedidoViewModel;
        public FrmPedido()
        {
            InitializeComponent();
            pedidoController = new PedidoController();
        }

        private void Insertar()
        {
            if (pedidoController.InsertarPedido(pedidoViewModel))
            {
                MessageBox.Show("Pedido insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el pedido");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            pedidoViewModel = new PedidoViewModel();
            pedidoViewModel.FechaHora = DtpFechaHora.Value;
            pedidoViewModel.NumPedido = TxtNumPedido.Text;
            pedidoViewModel.ClienteId = Convert.ToInt32(TxtClienteId.Text);
            pedidoViewModel.UsuarioId = Convert.ToInt32(TxtUsuarioId.Text);
            pedidoViewModel.Subtotal = Convert.ToDecimal(TxtSubtotal.Text);
            pedidoViewModel.Impuestos = Convert.ToDecimal(TxtImpuestos.Text);
            pedidoViewModel.Total = Convert.ToDecimal(TxtTotal.Text);
            pedidoViewModel.Estado = 1;
            Insertar();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
