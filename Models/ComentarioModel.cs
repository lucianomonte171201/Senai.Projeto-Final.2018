using System;

namespace Senai.Comentarios.Final.Models
{
    [Serializable]
    public class ComentarioModel
    {
    
        public UsuarioModel Usuario;
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime Data { get; set; }

        //Status do comentário: "Aprovado" "Recusado" "Aguardando"
        public string Status {get; set;}


        public ComentarioModel(UsuarioModel usuario, string texto, DateTime data, string status)
        {
            this.Usuario = usuario;
            this.Texto = texto;
            this.Data = data;
            this.Status = status;
        }

        public ComentarioModel(int id, UsuarioModel usuario, string texto, DateTime data, string status, int nota)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Texto = texto;
            this.Data = data;
            this.Status = status;
        }
        
    }
}