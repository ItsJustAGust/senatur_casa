using Senatur.Tarde.Domains;
using System.Collections.Generic;

namespace Senatur.Tarde.Interface
{
    public interface IPacoteRepository
    {
        List<PacoteDomain> Listar();

        void Cadastrar(PacoteDomain pacote);

        void Alterar(PacoteDomain pacote);

        void Remover(PacoteDomain pacote);

        PacoteDomain BuscarPacotePorId(int Id);
    }
}