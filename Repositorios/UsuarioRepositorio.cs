using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using Senai.Comentarios.Final.Interfaces;
using Senai.Comentarios.Final.Models;

namespace Senai.Comentarios.Final.Repositorios {
    public class UsuarioRepositorio : IUsuario {

        /// <summary>
        /// Lista de usuários cadastrados no sistema
        /// </summary>
        private List<UsuarioModel> UsuariosCadastrados { get; set; }

        public UsuarioRepositorio () {
            if (File.Exists ("usuarios.dat")) {
                UsuariosCadastrados = Leitura ();
            } else {
                UsuariosCadastrados = new List<UsuarioModel> ();

                UsuarioModel usuario = new UsuarioModel (
                    id: 1,
                    nome: "carfel",
                    email: "carfel@checkpoint.com",
                    senha: "carfel123",
                    admin : true
                );

                UsuariosCadastrados.Add (usuario);

                //Criando admin automaticamente
                Serializacao ();
            }
        }

        public UsuarioModel Cadastrar (UsuarioModel usuario) {
            // Adiciona o ID do usuário 
            usuario.Id = UsuariosCadastrados.Count + 1;

            // Adiciona o usuário a lista 
            UsuariosCadastrados.Add (usuario);

            Serializacao ();

            return usuario;
        }

        private void Serializacao () {
            // Irá armazenar os dados da lista 
            MemoryStream memoria = new MemoryStream ();

            // Objeto que fará a serialização
            BinaryFormatter serializador = new BinaryFormatter ();

            // Serializa os dados para a memoria
            serializador.Serialize (memoria, UsuariosCadastrados);

            byte[] bytes = memoria.ToArray ();

            File.WriteAllBytes ("usuarios.dat", bytes);
        }

        public List<UsuarioModel> Leitura () {
            byte[] bytesSerializados = File.ReadAllBytes ("usuarios.dat");

            MemoryStream memoria = new MemoryStream (bytesSerializados);

            // Cria o serializar para poder 'serializar' e 'deserializar' arquivos;
            BinaryFormatter serializador = new BinaryFormatter ();

            // Deserializa os dados para gerar a lista;
            return (List<UsuarioModel>) serializador.Deserialize (memoria);
        }

        public int Validacao (IFormCollection form) {

            if (string.IsNullOrEmpty (form["nome"])) {
                //Retorna 'case 1' caso o usuário não insira um nome
                return 1;
            }

            string senha = form["senha"];
            if (senha.Length < 5) {
                //Retorna 'case 2' caso o usuário insira uma senha com menos de 6 caracteres
                return 2;
            }

            //Retorna 'case 0' o usuário foi cadastrado
            return 0;
        }

        public UsuarioModel Login (string email, string senha) {
            foreach (UsuarioModel usuario in UsuariosCadastrados) {
                if (usuario.Email == email && usuario.Senha == senha) {
                    return usuario;
                }
            }

            return null;
        }

        public UsuarioModel BuscarPorId (int id) {
            foreach (UsuarioModel usuario in UsuariosCadastrados) {
                if (id == usuario.Id) {
                    return usuario;
                }
            }

            return null;
        }
    }
}