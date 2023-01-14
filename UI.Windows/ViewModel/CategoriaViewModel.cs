using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class CategoriaViewModel
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
