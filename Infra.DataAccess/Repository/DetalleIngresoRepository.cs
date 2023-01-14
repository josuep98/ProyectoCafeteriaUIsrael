using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class DetalleIngresoRepository : BaseRepository<DetalleiIngreso>, IDetalleIngresoRepository
    {
        public DetalleiIngreso Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
