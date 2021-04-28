using senai.hroads.webApi.Context;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class PersonagensRepository : IPersonagensRepository
    {
        HroadsContext ctx = new HroadsContext();
        public void Atualizar(int id, Personagens AtualizarPersonagem)
        {
            Personagens BuscarPersonagem = ctx.Personagens.Find(id);
            // -- Atualizar Nome --
            if (AtualizarPersonagem.Nome != null)
            {

                BuscarPersonagem.Nome = AtualizarPersonagem.Nome; 
            }
            // -- Atualizar Capacidade de Vida --
            if (AtualizarPersonagem.CapacidadeMaximadeVida != null)
            {

                BuscarPersonagem.CapacidadeMaximadeVida = AtualizarPersonagem.CapacidadeMaximadeVida;
            }
            // -- Atualizar Capacidade de Mana --
            if (AtualizarPersonagem.CapacidadeMaximadeMana != null)
            {
                BuscarPersonagem.CapacidadeMaximadeMana = AtualizarPersonagem.CapacidadeMaximadeMana;
            }
            ctx.Personagens.Update(BuscarPersonagem);
            ctx.SaveChanges();
        }

        public Personagens BuscarPorID(int id)
        {
            return ctx.Personagens.Find(id);
        }

        public void Cadastar(Personagens NovoPersonagem)
        {
            ctx.Personagens.Add(NovoPersonagem);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Personagens BuscarPersonagem = ctx.Personagens.Find(id);
            ctx.Personagens.Remove(BuscarPersonagem);
            ctx.SaveChanges();
        }

        public List<Personagens> Listar()
        {
            return ctx.Personagens.ToList();
        }
    }
}
