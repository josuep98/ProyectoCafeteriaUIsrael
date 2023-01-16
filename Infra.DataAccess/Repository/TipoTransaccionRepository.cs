using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class TipoTransaccionRepository : BaseRepository<TipoTransaccion>, ITipoTransaccionRepository
    {
        public TipoTransaccion Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoTransaccion> ListarTipoTransaccionActiva()
        {
            try
            {
                using (var context = new BdCafeteriaEntities1())
                {
                    var resultado = (from TipoTransaccion in context.TipoTransaccion
                                     where TipoTransaccion.Estado == 1
                                     select TipoTransaccion).ToList();
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
