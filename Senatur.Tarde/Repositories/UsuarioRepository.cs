using Senatur.Tarde.Context;
using Senatur.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Repositories
{
    public class UsuarioRepository
    {
        public void Listar(UsuarioDomain usuario)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Usuarios.ToList();
            }
        }
        public void Cadastrar(UsuarioDomain usuario)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }
        UsuarioDomain BuscarPorEmailESenha(string email, string senha)
        {
            using (SenaturContext ctx = new SenaturContext())
            {
                UsuarioDomain usuarioProcurado = ctx.Usuarios.Find(email, senha);
                if (usuarioProcurado == null)
                {
                    return null;
                }
                return usuarioProcurado;
            }

        }
    }
}
