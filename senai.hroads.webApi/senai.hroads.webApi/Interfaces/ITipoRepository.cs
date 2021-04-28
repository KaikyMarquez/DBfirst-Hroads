using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoRepository
    {
        List<Tipo> Listar();

        Tipo BuscarPorID(int id);

        void Cadastar(Tipo NovoTipo);

        void Atualizar(int id, Tipo AtualizarTipo);

        void Deletar(int id);
    }
}
