using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.ViewModel
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombres { get; set; }
        public string Pass { get; set; }
        public string Rol { get; set; }
        public Nullable<short> Estado { get; set; }
    }
}
