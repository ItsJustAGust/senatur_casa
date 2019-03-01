using Senatur.Tarde.Context;
using Senatur.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Repositories
{
    public class PacoteRepository
    {
        public void Listar(PacoteDomain pacote)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Pacote.ToList();
            }
        }
        public void Cadastrar(PacoteDomain pacote)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Pacote.Add(pacote);
                ctx.SaveChanges();
            }
        }
        public void Alterar(PacoteDomain pacote)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Pacote.Update(pacote);
                ctx.SaveChanges();
            }
        }
        PacoteDomain BuscarPacotePorId(int Id)
        {
            using(SenaturContext ctx = new SenaturContext())
                {
                PacoteDomain pacotesProcurados = ctx.Pacote.Find(Id);
                if (pacotesProcurados == null)
                {
                    return null;
                }
                return pacotesProcurados;
            }
        }

    }
}
