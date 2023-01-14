using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.ServicesEntity
{
    public class CategoriaServices
    {
        readonly ICategoriaRepository _categoriaRepository;
        public CategoriaServices()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        public IEnumerable<Categoria> GetCategoria()
        {
            return _categoriaRepository.GetAll();
        }

        public void InsertarCategoria(Categoria categoria)
        {
            _categoriaRepository.Add(categoria);
        }

        public void ModificarCategoria(Categoria categoria)
        {
            _categoriaRepository.Update(categoria);
        }

        public void EliminarCategoria(int Id)
        {
            _categoriaRepository.Delete(Id);
        }
    }
}
