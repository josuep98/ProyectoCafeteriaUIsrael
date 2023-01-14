using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class IngresoEgresoViewModel
    {
        public int IngresoEgresoId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> TipoTransaccionId { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
