using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Model.Abstractions
{
    public interface ICategoriaRepository : IBaseRepository<Categoria>
    {
        Categoria Buscar(string Ci);
        IEnumerable<Categoria> ListarCategoriasActivas();
    }
}
