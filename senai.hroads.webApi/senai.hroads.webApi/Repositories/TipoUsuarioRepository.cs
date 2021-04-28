using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, TipoUsuario AtualizarTipo)
        {
            TipoUsuario TipoUsuarioBuscado = ctx.TipoUsuarios.Find(id);
                if (AtualizarTipo.TipoUsuario1 != null)
            {
                TipoUsuarioBuscado.TipoUsuario1 = AtualizarTipo.TipoUsuario1;
            }
            ctx.TipoUsuarios.Update(TipoUsuarioBuscado);
            ctx.SaveChanges();
       
        }
        // Tá dando erro
        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuarios.Find(id);
        } 

        public void Deletar(int id)
        {
            TipoUsuario TipoBuscado = ctx.TipoUsuarios.Find(id);
            ctx.TipoUsuarios.Remove(TipoBuscado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> ListarTodos()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
