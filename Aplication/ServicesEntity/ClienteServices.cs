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
    public class ClienteServices
    {
        readonly IClienteRepository _clienteRepository;
        public ClienteServices()
        {
            _clienteRepository = new ClienteRepository();
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _clienteRepository.GetAll();
        }

        public void InsertarCliente(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public void ModificarCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void EliminarCliente(int Id)
        {
            _clienteRepository.Delete(Id);
        }
    }
}
