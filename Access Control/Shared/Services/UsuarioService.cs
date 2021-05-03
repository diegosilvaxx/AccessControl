using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Access_Control.Shared.Services
{
    public class UsuarioService
    {
        public async Task<List<Usuario>> GetUsuarios()
        {
            var usuario = new List<Usuario> 
            {
                new Usuario(1,"Diego","teste@gmail.com",new PermissaoDto{Id =  1,Nome = "admin",Permissao = true}),
                new Usuario(1,"Diego2","teste@gmail.com",new PermissaoDto{Id =  1,Nome = "admin",Permissao = true}),
            };
            return usuario;
        }
    }
}