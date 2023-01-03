using Aplication.ServicesEntity;
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
    public partial class FrmDetallePedido : Form
    {
        DetallePedidoController detallePedidoController;
        DetallePedidoViewModel detallePedidoViewModel;
        public FrmDetallePedido()
        {
            detallePedidoController = new DetallePedidoController();
            InitializeComponent();
        }

        private void Insertar()
        {
            if (detallePedidoController.InsertarDetallePedido(detallePedidoViewModel))
            {
                MessageBox.Show("Detalle del pedido insertado correctamente!");
            }
            else
                MessageBox.Show("ERROR! No se pudo insertar el detalle del pedido");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            detallePedidoViewModel = new DetallePedidoViewModel();
            detallePedidoViewModel.PedidoId = Convert.ToInt32(TxtPedidoId.Text);
            detallePedidoViewModel.Cantidad = Convert.ToInt32(TxtCantidad.Text);
            detallePedidoViewModel.ProductoId = Convert.ToInt32(TxtProductoId.Text);
            detallePedidoViewModel.ValorTotal = Convert.ToDecimal(TxtValorTotal.Text);
            detallePedidoViewModel.Estado = 1;
            Insertar();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
