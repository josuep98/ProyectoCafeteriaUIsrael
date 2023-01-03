using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class PedidoViewModel
    {
        public int PedidoId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public string NumPedido { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
