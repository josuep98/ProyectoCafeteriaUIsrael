using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class DetallePedidoViewModel
    {
        public int DetallePedidoId { get; set; }
        public Nullable<int> PedidoId { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<int> ProductoId { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public Nullable<short> Estado { get; set; }

    }
}
