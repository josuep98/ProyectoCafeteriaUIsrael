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
                producto.Cantidad = productoViewModel.Cantidad;
                producto.Costo = productoViewModel.Costo;
                producto.ValorUnitario = productoViewModel.ValorUnitario;
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
