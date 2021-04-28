using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class HabilidadeRepository : IHabilidadeRepository
    {

        HroadsContext ctx = new HroadsContext();

        public void Atualizar(int id, Habilidade novaHabilidade)
        {
            //FirstOrDefault -- Não Find//
            Habilidade habilidadeBus = ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);

            if (novaHabilidade.Habilidade1 != null)
            {

                habilidadeBus.Habilidade1 = novaHabilidade.Habilidade1;

            }

            ctx.Habilidades.Update(habilidadeBus);

            ctx.SaveChanges();


        }

        public Habilidade BuscarPorId(int id)
        {
            
            return ctx.Habilidades.FirstOrDefault(h => h.IdHabilidade == id);

        }

        public void Deletar(int Id)
        {
            Habilidade HabilidadesBuscada = ctx.Habilidades.Find(Id);
            ctx.Habilidades.Remove(HabilidadesBuscada);
            ctx.SaveChanges();
        }

        public List<Habilidade> ListarTodos()
        {
            return ctx.Habilidades.ToList();
        }
    }
}
