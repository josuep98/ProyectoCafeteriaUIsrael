using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public Categoria Buscar(string Ci)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> ListarCategoriasActivas()
        {
            try
            {
                using (var context = new BdCafeteriaEntities1())
                {
                    var resultado = (from Categoria in context.Categoria
                                     where Categoria.Estado == 1
                                     select Categoria).ToList();
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
