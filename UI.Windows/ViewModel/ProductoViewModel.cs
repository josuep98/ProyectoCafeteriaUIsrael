using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class ProductoViewModel
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<decimal> Pvp { get; set; }
        public Nullable<int> CategoriaId { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
