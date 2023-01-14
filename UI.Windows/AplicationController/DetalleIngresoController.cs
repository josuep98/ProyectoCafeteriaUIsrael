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
    public class DetalleIngresoController
    {
        private DetalleIngresoServices detalleIngresoServices = new DetalleIngresoServices();
        public bool InsertarDetalleIngreso(DetalleIngresoViewModel detalleIngresoViewModel)
        {
            DetalleiIngreso detalleIngreso = new DetalleiIngreso();
            try
            {
                detalleIngreso.Cantidad = detalleIngresoViewModel.Cantidad;
                detalleIngreso.PrecioUnitario = detalleIngresoViewModel.PrecioUnitario;
                detalleIngreso.PrecioFinal = detalleIngresoViewModel.PrecioFinal;
                detalleIngreso.Descripcion = detalleIngresoViewModel.Descripcion;
                detalleIngreso.ProductoId = detalleIngresoViewModel.ProductoId;
                detalleIngreso.IngresoEgresoId = detalleIngresoViewModel.IngresoEgresoId;
                detalleIngreso.Estado = detalleIngresoViewModel.Estado;
                detalleIngresoServices.InsertarDetalleiIngreso(detalleIngreso);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
