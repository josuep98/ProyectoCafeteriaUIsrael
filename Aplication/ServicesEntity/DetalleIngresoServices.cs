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
    public class DetalleIngresoServices
    {
        readonly IDetalleIngresoRepository _detalleIngresoRepository;
        public DetalleIngresoServices()
        {
            _detalleIngresoRepository = new DetalleIngresoRepository();
        }

        public IEnumerable<DetalleiIngreso> GetDetalleiIngreso()
        {
            return _detalleIngresoRepository.GetAll();
        }

        public void InsertarDetalleiIngreso(DetalleiIngreso detalleiIngreso)
        {
            _detalleIngresoRepository.Add(detalleiIngreso);
        }

        public void ModificarDetalleiIngreso(DetalleiIngreso detalleiIngreso)
        {
            _detalleIngresoRepository.Update(detalleiIngreso);
        }

        public void EliminarDetalleiIngreso(int Id)
        {
            _detalleIngresoRepository.Delete(Id);
        }
    }
}
