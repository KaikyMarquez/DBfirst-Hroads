using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IClasseRepository
    {
        List<Classes> Listar();

        Classes BuscarPorID(int id);

        void Cadastar(Classes NovaClasse);

        void Atualizar(int id, Classes AtualizarClasse);

        void Deletar(int id);


    }
}
