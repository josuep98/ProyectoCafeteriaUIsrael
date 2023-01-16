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

        public IEnumerable<DetalleIngresoViewModel> ListarDetalleIngresoEgresoActivo()
        {
            //Obtener información de la BD
            var listaDetalleiIngresos = detalleIngresoServices.ListarDetalleiIngresoActivo();
            //Crear objeto de entidades de vista
            List<DetalleIngresoViewModel> listaDetalleIngresoVM = new List<DetalleIngresoViewModel>();
            //Mapear datos de entidad
            foreach (var item in listaDetalleiIngresos)
            {
                listaDetalleIngresoVM.Add(new DetalleIngresoViewModel
                {
                    DetalleIngresoId = item.DetalleIngresoId,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = item.PrecioUnitario,
                    PrecioFinal = item.PrecioFinal,
                    IngresoEgresoId = item.IngresoEgresoId,
                    ProductoId = item.ProductoId,
                    Descripcion = item.Descripcion,
                    Estado = item.Estado
                });
            }
            return listaDetalleIngresoVM;
        }
    }
}
