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
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
