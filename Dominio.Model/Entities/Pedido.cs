//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pedido()
        {
            this.DetallePedido = new HashSet<DetallePedido>();
        }
    
        public int PedidoId { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public string NumPedido { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<short> Estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedido> DetallePedido { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
