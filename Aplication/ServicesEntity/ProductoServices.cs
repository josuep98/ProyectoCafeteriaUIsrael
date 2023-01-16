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
    public class ProductoServices
    {
        readonly IProductoRepository _productoRepository;
        public ProductoServices()
        {
            _productoRepository = new ProductoRepository();
        }

        //public IEnumerable<Producto> GetProductos()
        //{
        //    return _productoRepository.GetAll();
        //}

        public void InsertarProducto(Producto producto)
        {
            _productoRepository.Add(producto);
        }

        public void ModificarProducto(Producto producto)
        {
            _productoRepository.Update(producto);
        }

        public void EliminarProducto(int Id)
        {
            _productoRepository.Delete(Id);
        }
        public IEnumerable<Producto> ListarProductoActivo()
        {
            return _productoRepository.GetAll();
        }
    }
}
