using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface ITipoTransaccionRepository : IBaseRepository<TipoTransaccion>
    {
        TipoTransaccion Buscar(int id);
        IEnumerable<TipoTransaccion> ListarTipoTransaccionActiva();
    }
}
