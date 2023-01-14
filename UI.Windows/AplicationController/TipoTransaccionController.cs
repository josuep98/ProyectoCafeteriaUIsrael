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
    public class TipoTransaccionController
    {
        private TipoTransaccionServices tipoTransaccionServices = new TipoTransaccionServices();

        public bool InsertarTipoTransaccion(TipoTransaccionViewModel tipoTransaccionViewModel)
        {
            TipoTransaccion tipoTransaccion = new TipoTransaccion();
            try
            {
                tipoTransaccion.Descripcion = tipoTransaccionViewModel.Descripcion;
                tipoTransaccion.Estado = tipoTransaccionViewModel.Estado;
                tipoTransaccionServices.InsertarTipoTransaccion(tipoTransaccion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
