using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Comentarios.Final.Interfaces;
using Senai.Comentarios.Final.Models;

namespace Senai.Comentarios.Final.Repositorios {
    public class ComentarioRepositorio : IComentario {
        private List<ComentarioModel> ComentariosCadastrados { get; set; }

        public ComentarioRepositorio () {
            if (File.Exists ("comentarios.dat")) {
                ComentariosCadastrados = Leitura ();
            } else {
                ComentariosCadastrados = new List<ComentarioModel> ();
            }
        }

        public void Cadastrar (ComentarioModel comentario) {
            // Adiciona o ID do comentário 
            comentario.Id = ComentariosCadastrados.Count + 1;

            ComentariosCadastrados.Add (comentario);

            Serializacao ();

        }

        private void Serializacao () {
            MemoryStream memoria = new MemoryStream ();

            // Objeto que fará a serialização
            BinaryFormatter serializador = new BinaryFormatter ();

            // Serializa os dados para a memoria
            serializador.Serialize (memoria, ComentariosCadastrados);

            byte[] bytes = memoria.ToArray ();

            File.WriteAllBytes ("comentarios.dat", bytes);
        }

        public void Editar (string newStatus, ComentarioModel newComentario) {
            for (int i = 0; i < ComentariosCadastrados.Count; i++) {
                if (newComentario.Id == ComentariosCadastrados[i].Id) {
                    ComentariosCadastrados[i].Status = newStatus;

                    Serializacao ();

                    break;
                }
            }

        }
        public List<ComentarioModel> Leitura () {

            byte[] bytesSerializados = File.ReadAllBytes ("comentarios.dat");

            MemoryStream memoria = new MemoryStream (bytesSerializados);

            // Cria o serializar para poder 'serializar' e 'deserializar' arquivos;
            BinaryFormatter serializador = new BinaryFormatter ();

            // Deserializa os dados para gerar a lista;
            return (List<ComentarioModel>) serializador.Deserialize (memoria);
        }

        public ComentarioModel BuscarPorId (int id) {
            foreach (ComentarioModel comentario in ComentariosCadastrados) {
                if (id == comentario.Id) {
                    return comentario;
                }
            }

            return null;
        }

        public List<ComentarioModel> ListarComentarios () => ComentariosCadastrados;

        public List<ComentarioModel> ComentariosAvaliados (string status) {
            List<ComentarioModel> comentariosAvaliados = new List<ComentarioModel> ();

            foreach (ComentarioModel comentario in ComentariosCadastrados) {
                if (comentario.Status == status) {
                    comentariosAvaliados.Add (comentario);
                }
            }

            return comentariosAvaliados;
        }

    }
}