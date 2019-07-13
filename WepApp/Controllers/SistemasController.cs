using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SistemasController : Controller
    {
        // GET: Sistemas
        dalSistemasProjetos _db = new dalSistemasProjetos();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaProjetos();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Sistemas/Details/5
        public IActionResult Details(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaProjetoPorId(id);
            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Sistemas/Create
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

        // POST: Sistemas/Create
        [HttpPost]
        public IActionResult Create(modSistemasProjeto projetos)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _db.pubCadastraProjeto(projetos);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(projetos);
            //    }
            //}
            return View();           
        }

        // GET: Sistemas/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaProjetoPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Sistemas/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modSistemasProjeto projetos)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        projetos.idProjeto = id;
            //        _db.pubAtualizaProjeto(projetos);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}

            return View();
           
        }

        // GET: Sistemas/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaProjetoPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Sistemas/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modSistemasProjeto projetos)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        projetos.idProjeto = id;
            //        _db.pubRemoveProjeto(projetos);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(projetos);
            //    }
            //}

            return View();           
        }
    }
}
