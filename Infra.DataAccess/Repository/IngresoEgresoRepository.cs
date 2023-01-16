using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class IngresoEgresoRepository : BaseRepository<IngresoEgreso>, IIngresoEgresoRepository
    {
        public IngresoEgreso Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IngresoEgreso> ListarIngresoEgresoActivo()
        {
            try
            {
                using (var context = new BdCafeteriaEntities1())
                {
                    var resultado = (from IngresoEgreso in context.IngresoEgreso
                                     where IngresoEgreso.Estado == 1
                                     select IngresoEgreso).ToList();
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
