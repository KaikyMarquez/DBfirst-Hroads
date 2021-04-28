using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        List<TipoUsuario> ListarTodos();

        TipoUsuario BuscarPorId(int id);

        void Atualizar(int id, TipoUsuario NovoTipo);

        void Deletar(int id);

    }
}
