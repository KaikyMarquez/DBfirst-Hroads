using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuario> ListarTodos();

        Usuario BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(int id, Usuario NovoUsuario);

    }
}
