using Aplication.ServicesEntity;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class ProductoController
    {
        private ProductoServices productoServices = new ProductoServices();

        public bool InsertarProducto(ProductoViewModel productoViewModel)
        {
            Producto producto = new Producto();
            try
            {
                producto.Nombre = productoViewModel.Nombre;
                producto.Descripcion = productoViewModel.Descripcion;
                producto.Stock = productoViewModel.Stock;
                producto.Pvp = productoViewModel.Pvp;
                producto.CategoriaId = productoViewModel.CategoriaId;
                producto.Estado = productoViewModel.Estado;
                productoServices.InsertarProducto(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarProducto(ProductoViewModel productoViewModel)
        {
            Producto producto = new Producto();
            try
            {
                producto.ProductoId = productoViewModel.ProductoId;
                producto.Nombre = productoViewModel.Nombre;
                producto.Descripcion = productoViewModel.Descripcion;
                producto.Stock = productoViewModel.Stock;
                producto.Pvp = productoViewModel.Pvp;
                producto.CategoriaId = productoViewModel.CategoriaId;
                producto.Estado = productoViewModel.Estado;
                productoServices.ModificarProducto(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<ProductoViewModel> ListarProductoActivo()
        {
            //Obtener información de la BD
            var listaProducto = productoServices.ListarProductoActivo();
            //Crear objeto de entidades de vista
            List<ProductoViewModel> listaProductoVM = new List<ProductoViewModel>();
            //Mapear datos de entidad
            foreach (var item in listaProducto)
            {
                listaProductoVM.Add(new ProductoViewModel
                {
                    ProductoId = item.ProductoId,
                    Nombre = item.Nombre,
                    Descripcion = item.Descripcion,
                    Stock = item.Stock,
                    Pvp = item.Pvp,
                    CategoriaId = item.CategoriaId,
                    Estado = item.Estado
                });
            }
            return listaProductoVM;
        }
        public bool Eliminar(int id)
        {
            try
            {
                productoServices.EliminarProducto(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
