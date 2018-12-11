using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Comentarios.Final.Interfaces;
using Senai.Comentarios.Final.Models;
using Senai.Comentarios.Final.Repositorios;

namespace Senai.Comentarios.Final.Controllers {
    public class UsuarioController : Controller {
        public IUsuario UsuarioRepositorio { get; set; }

        public UsuarioController () {
            UsuarioRepositorio = new UsuarioRepositorio ();
        }

        [HttpGet]
        public IActionResult Cadastrar () {
            string id = HttpContext.Session.GetString ("IdUsuario");

            if (id != null) {
                int idInt = int.Parse (id);

                UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

                UsuarioModel usuario = usuarioRep.BuscarPorId (idInt);

                ViewBag.UsuarioLogado = usuario.Nome;
                ViewBag.AdminBool = usuario.Admin;
            } else {
                ViewBag.UsuarioLogado = null;
                ViewBag.UsuarioId = null;
            }
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar (IFormCollection form) {

            switch (UsuarioRepositorio.Validacao (form))
            {
                case 0:
                bool admin;

                    if (form["tipo"] == "true")
                    {
                        admin = true;
                    } else {
                        admin = false;
                    }

            UsuarioModel usuario = new UsuarioModel (
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                admin: admin
            );

            UsuarioRepositorio.Cadastrar (usuario);

            TempData["Mensagem"] = "Usuario cadastrado!";
            break;

            case 1: 
                TempData["Mensagem"] = "Insira um nome";
                break;

            case 2:
                TempData["Mensagem"] = "A senha deve conter no mínimo 6 caractéres";
                break;

            default: 
                TempData["Mensagem"] = "Erro!";
                break;
            }

            return RedirectToAction ("Login");
        }



        [HttpGet]
        public IActionResult Login () {
            return View ();
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModel usuario = UsuarioRepositorio.Login (form["email"], form["senha"]);

            if (usuario != null) {
                string[] nomes = usuario.Nome.Split (" ");

                HttpContext.Session.SetString ("IdUsuario", usuario.Id.ToString ());

                return RedirectToAction ("Home", "Pages");
            } else {
                ViewBag.Mensagem = "Usuário Inválido!";
                return View ();
            }
        }

        


        

        [HttpGet]
        public IActionResult Sair(){
            HttpContext.Session.Clear ();

            return RedirectToAction ("Home", "Pages");
        }
    }
}