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

        public IEnumerable<DetalleiIngreso> ListarDetalleiIngresoActivo()
        {
            try
            {
                using (var context = new BdCafeteriaEntities1())
                {
                    var resultado = (from DetalleIngreso in context.DetalleiIngreso
                                     where DetalleIngreso.Estado == 1
                                     select DetalleIngreso).ToList();
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo listar los datos" + ex.Message);
            }
        }

    }
}
