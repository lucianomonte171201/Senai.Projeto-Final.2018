using System;

namespace Senai.Comentarios.Final.Models
{
    [Serializable]
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Admin { get; set; }

        public UsuarioModel(int id, string nome, string email, string senha, bool admin)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Admin = admin;
        }

        public UsuarioModel(string nome, string email, string senha, bool admin)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Admin = admin;
        }
    }
}