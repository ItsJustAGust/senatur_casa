using Senatur.Tarde.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senatur.Tarde.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(UsuarioDomain usuario);

        void Listar(UsuarioDomain usuario);

        UsuarioDomain BuscarPorEmailESenha(string email, string senha);

        void Login(UsuarioDomain usuario);
    }
}
