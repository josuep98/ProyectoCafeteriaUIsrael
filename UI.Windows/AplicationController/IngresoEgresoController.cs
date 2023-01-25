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
    public class IngresoEgresoController
    {
        private IngresoEgresoServices ingresoEgresoServices = new IngresoEgresoServices();

        public bool InsertarIngresoEgreso(IngresoEgresoViewModel ingresoEgresoViewModel)
        {
            IngresoEgreso ingresoEgreso = new IngresoEgreso();
            try
            {
                ingresoEgreso.FechaHora = ingresoEgresoViewModel.FechaHora;
                ingresoEgreso.Descripcion = ingresoEgresoViewModel.Descripcion;
                ingresoEgreso.TipoTransaccionId = ingresoEgresoViewModel.TipoTransaccionId;
                ingresoEgreso.Estado = ingresoEgresoViewModel.Estado;
                ingresoEgresoServices.InsertarIngresoEgreso(ingresoEgreso);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarIngresoEgreso(IngresoEgresoViewModel ingresoEgresoViewModel)
        {
            IngresoEgreso ingresoEgreso = new IngresoEgreso();
            try
            {
                ingresoEgreso.IngresoEgresoId = ingresoEgresoViewModel.IngresoEgresoId;
                ingresoEgreso.FechaHora = ingresoEgresoViewModel.FechaHora;
                ingresoEgreso.Descripcion = ingresoEgresoViewModel.Descripcion;
                ingresoEgreso.TipoTransaccionId = ingresoEgresoViewModel.TipoTransaccionId;
                ingresoEgreso.Estado = ingresoEgresoViewModel.Estado;
                ingresoEgresoServices.ModificarIngresoEgreso(ingresoEgreso);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<IngresoEgresoViewModel> ListarIngresoEgresoActivo()
        {
            //Obtener información de la BD
            var listaIngresoEgreso = ingresoEgresoServices.ListarIngresoEgresoActivo();
            //Crear objeto de entidades de vista
            List<IngresoEgresoViewModel> listaIngresoEgresoVM = new List<IngresoEgresoViewModel>();
            //Mapear datos de entidad
            foreach (var item in listaIngresoEgreso)
            {
                listaIngresoEgresoVM.Add(new IngresoEgresoViewModel
                {
                    IngresoEgresoId = item.IngresoEgresoId,
                    FechaHora = item.FechaHora,
                    Descripcion = item.Descripcion,
                    TipoTransaccionId = item.TipoTransaccionId,
                    Estado = item.Estado
                });
            }
            return listaIngresoEgresoVM;
        }

    }
}
