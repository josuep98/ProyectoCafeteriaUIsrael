using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Identificacion { get; set; }
        public Nullable<short> TipoIdentificacion { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
