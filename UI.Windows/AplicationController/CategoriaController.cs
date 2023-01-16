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

        public IEnumerable<CategoriaViewModel> ListarCategoriasActivas()
        {
            //Obtener información de la BD
            var listaCategorias = categoriaServices.ListarCategoriasActivas();
            //Crear objeto de entidades de vista
            List<CategoriaViewModel> listaCategoriasVM = new List<CategoriaViewModel>();
            //Mapear datos de entidad
            foreach (var item in listaCategorias)
            {
                listaCategoriasVM.Add(new CategoriaViewModel
                {
                    CategoriaId = item.CategoriaId,
                    Descripcion = item.Descripcion,
                    Estado = item.Estado
                });
            }
            return listaCategoriasVM;
        }

    }
}
