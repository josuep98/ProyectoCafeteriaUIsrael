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
    }
}
