using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PrioridadeController : Controller
    {
        // GET: Prioridade
        dalPrioridade _db = new dalPrioridade();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaPrioridades();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Prioridade/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Prioridade/Create
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

        // POST: Prioridade/Create
        [HttpPost]
        public IActionResult Create(modPrioridade prioridade)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _db.pubCadastraPrioridade(prioridade);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(prioridade);
            //    }
            //}
            return View();
        }

        // GET: Prioridade/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaPrioridadePorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Prioridade/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modPrioridade prioridade)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        prioridade.idPrioridade = id;
            //        _db.pubAtualizaPrioridade(prioridade);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(prioridade);
            //    }
            //}
            return View();
        }

        // GET: Prioridade/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaPrioridadePorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Prioridade/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modPrioridade prioridade)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        prioridade.idPrioridade = id;
            //        _db.pubRemovePrioridade(prioridade);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(prioridade);
            //    }
            //}
            return View();
        }
    }
}
