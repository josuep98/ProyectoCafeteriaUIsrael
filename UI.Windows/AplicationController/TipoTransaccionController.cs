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

        public bool ModificarTipoTransaccion(TipoTransaccionViewModel tipoTransaccionViewModel)
        {
            TipoTransaccion tipoTransaccion = new TipoTransaccion();
            try
            {
                tipoTransaccion.TipoTransaccionId = tipoTransaccionViewModel.TipoTransaccionId;
                tipoTransaccion.Descripcion = tipoTransaccionViewModel.Descripcion;
                tipoTransaccion.Estado = tipoTransaccionViewModel.Estado;
                tipoTransaccionServices.ModificarTipoTransaccion(tipoTransaccion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<TipoTransaccionViewModel> ListarTipoTransaccion()
        {
            //Obtener información de la BD
            var listaTipoTransaccion = tipoTransaccionServices.ListarTipoTransaccionActiva();
            //Crear objeto de entidades de vista
            List<TipoTransaccionViewModel> listaTipoTransaccionVM = new List<TipoTransaccionViewModel>();
            //Mapear datos de entidad
            foreach (var item in listaTipoTransaccion)
            {
                listaTipoTransaccionVM.Add(new TipoTransaccionViewModel
                {
                    TipoTransaccionId = item.TipoTransaccionId,
                    Descripcion = item.Descripcion,
                    Estado = item.Estado
                });
            }
            return listaTipoTransaccionVM;
        }

        public bool Eliminar(int id)
        {
            try
            {
                tipoTransaccionServices.EliminarTipoTransaccion(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
