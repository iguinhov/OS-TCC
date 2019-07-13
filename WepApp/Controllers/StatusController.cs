using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class StatusController : Controller
    {
        // GET: Status
        dalStatus _db = new dalStatus();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaStatus();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Status/Details/5
        public IActionResult Details(int id)
        {
            //    if (Session["NomeLogin"] != null)
            //    {
            //        var model = _db.pubBuscaStatusPorId(id);

            //        return View(model);
            //    }
            //    else
            //    {
            //        return RedirectToAction("Logar", "Usuario");
            //    }
            return View();
        }

        // GET: Status/Create
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

        // POST: Status/Create
        [HttpPost]
        public IActionResult Create(modStatus status)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {                    
            //        _db.pubCadastraStatus(status);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(status);
            //    }
            //}
            return View();
            
        }

        // GET: Status/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaStatusPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Status/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modStatus status)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        status.idStatus = id;
            //        _db.pubAtualizaStatus(status);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(status);
            //    }
            //}
            return View();
            
        }

        // GET: Status/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaStatusPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Status/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modStatus status)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        status.idStatus = id;

            //        _db.pubRemoveStatusPorId(status);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(status);
            //    }
            //}
            return View();
           
        }
    }
}
