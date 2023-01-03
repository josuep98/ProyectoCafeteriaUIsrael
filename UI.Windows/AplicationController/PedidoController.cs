using Aplication.ServicesEntity;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class PedidoController
    {
        private PedidoServices pedidoServices = new PedidoServices();

        public bool InsertarPedido(PedidoViewModel pedidoViewModel)
        {
            Pedido pedido = new Pedido();
            try
            {
                pedido.FechaHora = pedidoViewModel.FechaHora;
                pedido.NumPedido = "0000" +pedidoViewModel.NumPedido;
                pedido.ClienteId = pedidoViewModel.ClienteId;
                pedido.UsuarioId = pedidoViewModel.UsuarioId;
                pedido.Subtotal = pedidoViewModel.Subtotal;
                pedido.Impuestos = pedidoViewModel.Impuestos;
                pedido.Total = pedidoViewModel.Total;
                pedido.Estado = pedidoViewModel.Estado;
                pedidoServices.InsertarPedido(pedido);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
