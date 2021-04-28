using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IPersonagensRepository
    {
        List<Personagens> Listar();

        Personagens BuscarPorID(int id);

        void Cadastar(Personagens NovoPersonagem);

        void Atualizar(int id, Personagens AtualizarPersonagem);

        void Deletar(int id);
    }
}
