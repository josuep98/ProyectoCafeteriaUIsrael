using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class ProductoRepository : BaseRepository<Producto>, IProductoRepository
    {
        public Producto Buscar(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ListarProductoActivo()
        {
            try
            {
                using (var context = new BdCafeteriaEntities1())
                {
                    var resultado = (from Producto in context.Producto
                                     where Producto.Estado == 1
                                     select Producto).ToList();
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
