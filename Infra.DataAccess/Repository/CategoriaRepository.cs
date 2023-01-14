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
    }
}
