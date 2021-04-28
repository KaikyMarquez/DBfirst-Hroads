using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClassesRepository : IClasseRepository

    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, Classes AtualizarClasse)
        {
            Classes ClasseBuscada = ctx.Classes.Find(id);
            if (AtualizarClasse.Classe != null)
            {
                ClasseBuscada.Classe = AtualizarClasse.Classe;
            }
            ctx.Classes.Update(ClasseBuscada);
            ctx.SaveChanges();
        }


        public Classes BuscarPorID(int id)
        {
            return ctx.Classes.Find(id);
        }

        public void Cadastar(Classes NovaClasse)
        {
            ctx.Classes.Add(NovaClasse);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Classes ClasseBuscada = ctx.Classes.Find(id);
            ctx.Classes.Remove(ClasseBuscada);
            ctx.SaveChanges();
        }

        public List<Classes> Listar()
        {
            return ctx.Classes.ToList();
        }
    }
}
