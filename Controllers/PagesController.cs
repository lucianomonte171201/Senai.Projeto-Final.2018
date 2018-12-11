using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Comentarios.Final.Models;
using Senai.Comentarios.Final.Repositorios;
using Senai.Comentarios.Final.Enums;

namespace Senai.Comentarios.Final.Controllers
{
    public class PagesController : Controller
    {
        [HttpGet]
        public IActionResult Home () {
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                int idInt = int.Parse (id);

                UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

                UsuarioModel usuario = usuarioRep.BuscarPorId (idInt);


                string[] nomes = usuario.Nome.Split (" ");

                ViewBag.UsuarioLogado = nomes[0];
                ViewBag.UsuarioId = usuario.Id;
                ViewBag.AdminBool = usuario.Admin;
            } else {
                ViewBag.UsuarioLogado = null;
                ViewBag.UsuarioId = null;
            }
            
            ComentarioRepositorio comentario = new ComentarioRepositorio();
            
            ViewData["ComentariosAprovados"] = comentario.ComentariosAvaliados(Avaliacao.Aprovado.ToString());

            return View ();
        }

        public IActionResult Sobre () {
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                int idInt = int.Parse (id);

                UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

                UsuarioModel usuario = usuarioRep.BuscarPorId (idInt);

                string[] nomes = usuario.Nome.Split (" ");

                ViewBag.UsuarioLogado = nomes[0];
                ViewBag.AdminBool = usuario.Admin;
            } else {
                ViewBag.UsuarioLogado = null;
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Formulario () {
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                int idInt = int.Parse (id);

                UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

                UsuarioModel usuario = usuarioRep.BuscarPorId (idInt);

                string[] nomes = usuario.Nome.Split (" ");

                ViewBag.UsuarioLogado = nomes[0];
                ViewBag.AdminBool = usuario.Admin;
            } else {
                ViewBag.UsuarioLogado = null;
            }
            return View ();
        }

        [HttpGet]
        public IActionResult Contato () {
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                int idInt = int.Parse (id);

                UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

                UsuarioModel usuario = usuarioRep.BuscarPorId (idInt);

                string[] nomes = usuario.Nome.Split (" ");

                ViewBag.UsuarioLogado = nomes[0];
                ViewBag.AdminBool = usuario.Admin;
            } else {
                ViewBag.UsuarioLogado = null;
            }
            return View ();
        }
    }
}