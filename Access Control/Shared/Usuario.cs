using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Control.Shared
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(int id,string name, string email,PermissaoDto permissao)
        {
            Id = id;
            Nome = name;
            Email = email;
            Permissao = permissao;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public PermissaoDto Permissao { get; set; }

    }
    public class PermissaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Permissao { get; set; }
    }
}