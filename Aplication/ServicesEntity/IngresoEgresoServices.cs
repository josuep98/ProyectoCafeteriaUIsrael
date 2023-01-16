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
    public class IngresoEgresoServices
    {
        readonly IIngresoEgresoRepository _ingresoEgresoRepository;
        public IngresoEgresoServices()
        {
            _ingresoEgresoRepository = new IngresoEgresoRepository();
        }

        public IEnumerable<IngresoEgreso> GetIngresoEgreso()
        {
            return _ingresoEgresoRepository.GetAll();
        }

        public void InsertarIngresoEgreso(IngresoEgreso ingresoEgreso)
        {
            _ingresoEgresoRepository.Add(ingresoEgreso);
        }

        public void ModificarIngresoEgreso(IngresoEgreso ingresoEgreso)
        {
            _ingresoEgresoRepository.Update(ingresoEgreso);
        }

        public void EliminarIngresoEgreso(int Id)
        {
            _ingresoEgresoRepository.Delete(Id);
        }

        public IEnumerable<IngresoEgreso> ListarIngresoEgresoActivo()
        {
            return _ingresoEgresoRepository.ListarIngresoEgresoActivo();
        }
    }
}
