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
    public class TipoTransaccionServices
    {
        readonly ITipoTransaccionRepository _tipoTransaccionRepository;
        public TipoTransaccionServices()
        {
            _tipoTransaccionRepository = new TipoTransaccionRepository();
        }

        public IEnumerable<TipoTransaccion> GetTipoTransaccion()
        {
            return _tipoTransaccionRepository.GetAll();
        }

        public void InsertarTipoTransaccion(TipoTransaccion tipoTransaccion)
        {
            _tipoTransaccionRepository.Add(tipoTransaccion);
        }

        public void ModificarTipoTransaccion(TipoTransaccion tipoTransaccion)
        {
            _tipoTransaccionRepository.Update(tipoTransaccion);
        }

        public void EliminarTipoTransaccion(int Id)
        {
            _tipoTransaccionRepository.Delete(Id);
        }
    }
}
