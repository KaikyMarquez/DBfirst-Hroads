using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
   
    public class TipoRepository : ITipoRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, Tipo AtualizarTipo)
        {
            Tipo BuscarTipo = ctx.Tipos.Find(id);
            if (AtualizarTipo.Tipo1 != null)
            {
                BuscarTipo.Tipo1 = AtualizarTipo.Tipo1;
            }
            ctx.Tipos.Update(BuscarTipo);
            ctx.SaveChanges();

        }

        public Tipo BuscarPorID(int id)
        {
            return ctx.Tipos.Find(id);
        }

        public void Cadastar(Tipo NovoTipo)
        {
            ctx.Tipos.Add(NovoTipo);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Tipo BuscarTipo = ctx.Tipos.Find(id);
            ctx.Tipos.Remove(BuscarTipo);
            ctx.SaveChanges();
        }

        public List<Tipo> Listar()
        {
            return ctx.Tipos.ToList();
        }
    }
}
