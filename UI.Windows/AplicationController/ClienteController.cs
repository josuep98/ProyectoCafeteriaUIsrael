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
    public class ClienteController
    {
        private ClienteServices clienteServices = new ClienteServices();

        public bool InsertarCliente(ClienteViewModel clienteViewModel)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Nombres = clienteViewModel.Nombres;
                cliente.Direccion = clienteViewModel.Direccion;
                cliente.Telefono = clienteViewModel.Telefono;
                cliente.TipoIdentificacion = clienteViewModel.TipoIdentificacion;
                cliente.Identificacion = clienteViewModel.Identificacion;
                cliente.Estado = clienteViewModel.Estado;
                clienteServices.InsertarCliente(cliente);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
