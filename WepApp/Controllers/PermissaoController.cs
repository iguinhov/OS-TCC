using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PermissaoController : Controller
    {
        // GET: Permissao
        dalTipoUsuario _db = new dalTipoUsuario(); 
        public IActionResult Index()
        {
        //    if (Session["NomeLogin"] != null)
        //    {
        //        var model = _db.pubListaTipoUsuarios();

        //        return View(model);
        //    }
        //    else
        //    {
        //        return RedirectToAction("Logar", "Usuario");
        //    }
         return View();
    }

        // GET: Permissao/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Permissao/Create
        public IActionResult Create()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Permissao/Create
        [HttpPost]
        public IActionResult Create(modTipoUsuario tpUsuario)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _db.pubCadastraTipoUsuario(tpUsuario);

            //        return RedirectToAction("Index");
            //    }

            //    catch
            //    {
            //        return View(tpUsuario);
            //    }
            //}
            return View();
        }

        // GET: Permissao/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubTipoUsuarioPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Permissao/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modTipoUsuario tpUsuario)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        tpUsuario.idTipoUsuario = id;
            //        _db.pubAtualizaTipoUsuario(tpUsuario);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(tpUsuario);
            //    }
            //}

            return View();
        }

        // GET: Permissao/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubTipoUsuarioPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Permissao/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modTipoUsuario tpUsuario)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        tpUsuario.idTipoUsuario = id;
            //        _db.pubRemoveUsuarioPorId(tpUsuario);

            //        return RedirectToAction("Index");

            //    }

            //    catch
            //    {
            //        return View(tpUsuario);
            //    }
            //}
            return View();
        }
    }
}
