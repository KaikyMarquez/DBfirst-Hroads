using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, Usuario AtualizarUsuario)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(id);
            if (AtualizarUsuario.Email != null)
            {
                UsuarioBuscado.Email = AtualizarUsuario.Email;
            }
            ctx.Usuarios.Update(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario BuscarUsuario = ctx.Usuarios.Find(id);
            ctx.Usuarios.Remove(BuscarUsuario);
            ctx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return ctx.Usuarios.ToList();
        }
    }
}
