using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class TipoTransaccionViewModel
    {
        public int TipoTransaccionId { get; set; }
        public string Descripcion { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
