using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        HroadsContext ctx = new HroadsContext();

        public Usuario Autenticacao(string email, string senha)
        {
            Usuario usuarioBuscado = new Usuario();

            //if (ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha) == null)

            //{

              //  return null;

           // }

            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);


        }
    }
}
