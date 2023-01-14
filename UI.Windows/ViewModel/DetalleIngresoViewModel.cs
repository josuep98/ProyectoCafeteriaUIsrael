using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class DetalleIngresoViewModel
    {
        public int DetalleIngresoId { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> PrecioFinal { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> ProductoId { get; set; }
        public Nullable<int> IngresoEgresoId { get; set; }
        public Nullable<short> Estado { get; set; }

    }
}
