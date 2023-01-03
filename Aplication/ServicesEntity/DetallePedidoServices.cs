using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.ServicesEntity
{
    public class DetallePedidoServices
    {
        readonly IDetallePedidoRepository _detallePedidoRepository;
        public DetallePedidoServices()
        {
            _detallePedidoRepository = new DetallePedidoRepository();
        }

        public IEnumerable<DetallePedido> GetPedidos()
        {
            return _detallePedidoRepository.GetAll();
        }

        public void InsertarDetallePedido(DetallePedido detallePedido)
        {
            _detallePedidoRepository.Add(detallePedido);
        }

        public void ModificarDetallePedido(DetallePedido detallePedido)
        {
            _detallePedidoRepository.Update(detallePedido);
        }

        public void EliminarDetallePedido(int Id)
        {
            _detallePedidoRepository.Delete(Id);
        }
    }
}
