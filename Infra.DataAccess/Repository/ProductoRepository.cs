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
    }
}
