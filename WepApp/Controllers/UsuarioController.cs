using System;
using System.Linq;
using System.Web;
using Model;
using System.IO;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace WepApp.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Logar(string login, string senha)
        {
            modUsuarios usuarios = new modUsuarios();

            //if (login == null || senha == null)
            //{
            //    return View();
            //}
            //else
            //{
            //    if (ModelState.IsValid)
            //    {

            //        var model = _db.pubUsuarioLogar(login, senha);

            //        if (model != null)
            //        {
            //            Session["idUsuario"] = model.idUsuario;
            //            Session["NomeLogin"] = login;
            //            Session["ImagePerfil"] = model.imagem;


            //            return RedirectToAction("Index", "Home");
            //        }

            //        else
            //        {
            //            ViewBag.Erro = "Usuário ou senha inválidos, tente novamente!";
            //            return View();
            //        }
            //    }
                return View(usuarios);
            }
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult GetImage()
        {
            //byte[] imageBytes = (byte[])HttpContext.Session["ImagePerfil"];
           // MemoryStream ms = new MemoryStream(imageBytes);
            //return File(ms, "image/png", "myimage.png");
            return View();
        }


        // GET: Usuario
        public IActionResult Create()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    ViewBag.Departamento = new SelectList(dbContext.TB_DEPARTAMENTO, "ID_DEPARTAMENTO", "NOME");
            //    ViewBag.TipoUsuario = new SelectList(dbContext.TB_TIPO_USUARIO, "ID_TIPO_USUARIO", "DESCRICAO");

            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(modUsuarios usuarios)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        int anexo = 0;

            //        for (int i = 0; i < Request.Files.Count; i++)
            //        {
            //            HttpPostedFileBase arquivo = Request.Files[i];
            //            var imagem = Image.FromStream(arquivo.InputStream, true, true);
            //            if (arquivo.ContentLength > 0)
            //            {
            //                MemoryStream ms = new MemoryStream();
            //                imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //                anexo++;
            //                usuarios.imagem = ms.ToArray();

            //            }
            //        }

            //        usuarios.dtCadastro = DateTime.Now;
            //        _db.pubCadastraNovoUsuario(usuarios);

            //        return RedirectToAction("Index");

            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}
            //else
            //{
            //    ViewBag.Departamento = new SelectList(dbContext.TB_DEPARTAMENTO, "ID_DEPARTAMENTO", "NOME", usuarios.idDepartamento);
            //    ViewBag.TipoUsuario = new SelectList(dbContext.TB_TIPO_USUARIO, "ID_TIPO_USUARIO", "DESCRICAO", usuarios.idTipoUsuario);

            //    return View(usuarios);
            //}

            return View();
        }

        // GET: Usuario/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    modUsuarios usuario = new modUsuarios();

            //    ViewBag.Departamento = new SelectList(dbContext.TB_DEPARTAMENTO, "ID_DEPARTAMENTO", "NOME");
            //    ViewBag.TipoUsuario = new SelectList(dbContext.TB_TIPO_USUARIO, "ID_TIPO_USUARIO", "DESCRICAO");

            //    var model = _db.pubBuscaUsuarioPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modUsuarios usuario)
        {
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            int anexo = 0;

        //            for (int i = 0; i < Request.Files.Count; i++)
        //            {
        //                HttpPostedFileBase arquivo = Request.Files[i];
        //                var imagem = Image.FromStream(arquivo.InputStream, true, true);
        //                if (arquivo.ContentLength > 0)
        //                {
        //                    MemoryStream ms = new MemoryStream();
        //                    imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //                    anexo++;
        //                    usuario.imagem = ms.ToArray();

        //                }
        //            }

        //            usuario.idUsuario = id;
        //            usuario.dtAlteracao = DateTime.Now;

        //            _db.pubAtualizaUsuario(usuario);

        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View(usuario);
        //        }
        //    }
        //    ViewBag.Departamento = new SelectList(dbContext.TB_DEPARTAMENTO, "ID_DEPARTAMENTO", "NOME", usuario.idDepartamento);
        //    ViewBag.TipoUsuario = new SelectList(dbContext.TB_TIPO_USUARIO, "ID_TIPO_USUARIO", "DESCRICAO", usuario.idTipoUsuario);

            return View();
        }

        // GET: Usuario/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        //Desloga usuário
        public IActionResult Deslogar()
        {
            //int id = 0;

            //id = Convert.ToInt32(Session["idUsuario"]);

            //_db.pubUsuarioDeslogar(id);

            //Session["idUsuario"] = null;
            //Session["NomeLogin"] = null;
            //Session["ImagePerfil"] = null;

            return RedirectToAction("Logar");
        }

        //Compara a sessão do login para identificar se está valida e usuário pode alterar nome/senha.
        public IActionResult PerfilUsuario(string login)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    login = Session["NomeLogin"].ToString();

            //    var model = _db.pubUsuarioPropriedadesPerfil(login);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        //Utiliza o perfil para alterar o nome ou a senha da conta.
        [HttpPost]
        public IActionResult PerfilUsuario(string login, modUsuarios usuario)
        {
            //int anexo = 0;

            //for (int i = 0; i < Request.Files.Count; i++)
            //{
            //    HttpPostedFileBase arquivo = Request.Files[i];
            //    var imagem = Image.FromStream(arquivo.InputStream, true, true);
            //    if (arquivo.ContentLength > 0)
            //    {
            //        MemoryStream ms = new MemoryStream();
            //        imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //        anexo++;
            //        usuario.imagem = ms.ToArray();
            //    }
            //}

            //login = Session["NomeLogin"].ToString();

            //usuario.login = login;

            //_db.pubAtualizaPerfilUsuarioNomeSenha(usuario);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult RedefinirSenhaLogon()
        {
            return View();
        }
    }
    }
