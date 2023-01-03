using Dominio.Model.Abstractions;
using Dominio.Model.Entities;
using Infra.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.ServicesEntity
{
    public class UsuarioServices
    {
        readonly IUsuarioRepository _usuarioRepository;
        public UsuarioServices()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public void ModificarUsuario(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void EliminarUsuario(int Id)
        {
            _usuarioRepository.Delete(Id);
        }
    }
}
