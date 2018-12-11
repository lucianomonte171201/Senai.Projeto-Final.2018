using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Comentarios.Final.Interfaces;
using Senai.Comentarios.Final.Models;
using Senai.Comentarios.Final.Repositorios;
using Senai.Comentarios.Final.Enums;

namespace Senai.Comentarios.Final.Controllers {
    public class ComentarioController : Controller {
        private IComentario ComentarioRepositorio { get; set; }

        public ComentarioController () {
            ComentarioRepositorio = new ComentarioRepositorio ();
        }

        
        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

            UsuarioModel usuario = usuarioRep.BuscarPorId (int.Parse (form["id"]));

            ComentarioModel comentarioModel = new ComentarioModel (
                //obter e armazenar o usuario da session
                usuario : usuario,
                texto : form["comentario"],
                data : DateTime.Now,
                status : Avaliacao.Aguardando.ToString ()
            );

            ComentarioRepositorio.Cadastrar (comentarioModel);

            TempData["Mensagem"] = "Comentário enviado!";

            return RedirectToAction ("Home", "Pages");
        }

        [HttpGet]
        public IActionResult Gerenciar () {
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

            if (HttpContext.Session.GetString ("IdUsuario") != null) {
                int id = int.Parse (HttpContext.Session.GetString ("IdUsuario"));

                UsuarioModel usuario = usuarioRep.BuscarPorId (id);

                if (usuario.Admin) {

                    ComentarioRepositorio comentarioRep = new ComentarioRepositorio ();

                    /// <summary>
                    /// Retorna somente os comentários com status definido pelo admin
                    /// </summary>
                    /// <returns></returns>
                    ViewData["ComentariosEmEspera"] = comentarioRep.ComentariosAvaliados (Avaliacao.Aguardando.ToString ());

                    return View ();
                } else {
                    return RedirectToAction ("Home", "Pages");
                }
            } else {
                return RedirectToAction ("Login", "Usuario");
            }

        }

        [HttpPost]
        public IActionResult Gerenciar (IFormCollection form) {
            int ComentarioId = int.Parse (form["comentarioId"]);

            ComentarioRepositorio comentarioRep = new ComentarioRepositorio ();

            ComentarioModel comentarioModel = comentarioRep.BuscarPorId (ComentarioId);

            if (form["opcao"] == "aceito") {
                comentarioRep.Editar (Avaliacao.Aprovado.ToString (), comentarioModel);
            } else {
                if (form["opcao"] == "recusado") {
                    comentarioRep.Editar (Avaliacao.Recusado.ToString (), comentarioModel);
                } else {
                    ViewBag.Mensagem = "Opção inválida!";
                    return View ();
                }
            }

            ViewBag.Mensagem = $"Status do comentário alterado!";

            return RedirectToAction ("Gerenciar");
        }

        [HttpGet]
        public IActionResult Cadastrar () {

            if (string.IsNullOrEmpty (HttpContext.Session.GetString ("idUsuario"))) {
                return RedirectToAction ("Login", "Usuario");
            }

            return View ();
        }

    }
}