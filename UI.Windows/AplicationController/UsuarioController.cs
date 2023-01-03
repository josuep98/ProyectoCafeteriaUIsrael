using Aplication.ServicesEntity;
using Dominio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.ViewModel;

namespace UI.Windows.AplicationController
{
    public class UsuarioController
    {
        private UsuarioServices usuarioServices = new UsuarioServices();

        public bool InsertarUsuario(UsuarioViewModel usuarioViewModel)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario.NombreUsuario = usuarioViewModel.NombreUsuario;
                usuario.Nombres = usuarioViewModel.Nombres;
                usuario.Pass = usuarioViewModel.Pass;
                usuario.Rol = usuarioViewModel.Rol;
                usuario.Estado = usuarioViewModel.Estado;
                usuarioServices.InsertarUsuario(usuario);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
