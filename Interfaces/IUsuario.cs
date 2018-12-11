using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Senai.Comentarios.Final.Models;

namespace Senai.Comentarios.Final.Interfaces {
    /// <summary>
    /// Interface do Usuário
    /// Metódos que a classe que irá herdar deverá ter
    /// </summary>
    public interface IUsuario {
        /// <summary>
        /// Cadastrar um novo usuário
        /// </summary>
        /// <param name="usuario">UsuarioModel</param>
        /// <returns>Retorna um usuário</returns>
        UsuarioModel Cadastrar (UsuarioModel usuario);
        
        /// <summary>
        /// Efetua o login do usuário
        /// </summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns></returns>
         UsuarioModel Login(string email, string senha);

         int Validacao(IFormCollection form);
    }
}