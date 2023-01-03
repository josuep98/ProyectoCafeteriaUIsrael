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
    public class PedidoServices
    {
        readonly IPedidoRepository _pedidoRepository;
        public PedidoServices()
        {
            _pedidoRepository = new PedidoRepository();
        }

        public IEnumerable<Pedido> GetPedidos()
        {
            return _pedidoRepository.GetAll();
        }

        public void InsertarPedido(Pedido pedido)
        {
            _pedidoRepository.Add(pedido);
        }

        public void ModificarPedido(Pedido pedido)
        {
            _pedidoRepository.Update(pedido);
        }

        public void EliminarPedido(int Id)
        {
            _pedidoRepository.Delete(Id);
        }
    }
}
