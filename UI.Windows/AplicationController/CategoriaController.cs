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
    public class CategoriaController
    {
        private CategoriaServices categoriaServices = new CategoriaServices();

        public bool InsertarCategoria(CategoriaViewModel categoriaViewModel)
        {
            Categoria categoria = new Categoria();
            try
            {
                categoria.Descripcion = categoriaViewModel.Descripcion;
                categoria.Estado = categoriaViewModel.Estado;
                categoriaServices.InsertarCategoria(categoria);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
