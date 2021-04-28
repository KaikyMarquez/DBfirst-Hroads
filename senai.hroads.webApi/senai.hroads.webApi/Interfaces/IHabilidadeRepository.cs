using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IHabilidadeRepository
    {

        List<Habilidade> ListarTodos();

        Habilidade BuscarPorId(int id);

        void Deletar(int Id);

        void Atualizar(int id, Habilidade novaHabilidade);

    }
}
