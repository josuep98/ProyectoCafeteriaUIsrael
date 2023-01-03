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
    public class DetallePedidoController
    {
        private DetallePedidoServices detallePedidoServices = new DetallePedidoServices();
        public bool InsertarDetallePedido(DetallePedidoViewModel detallepedidoViewModel)
        {
            DetallePedido detallePedido = new DetallePedido();
            try
            {
                detallePedido.PedidoId = detallepedidoViewModel.PedidoId;
                detallePedido.Cantidad = detallepedidoViewModel.Cantidad;
                detallePedido.ProductoId = detallepedidoViewModel.ProductoId;
                detallePedido.ValorTotal = detallepedidoViewModel.ValorTotal;
                detallePedido.Estado = detallepedidoViewModel.Estado;
                detallePedidoServices.InsertarDetallePedido(detallePedido);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
