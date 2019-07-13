using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
    public class DesenvolvedoresController : Controller
    {
        // GET: Desenvolvedores
        dalDesenvolvedores _db = new dalDesenvolvedores();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        var model = _db.pubListaDesenvolvedores();

            //        return View(model);
            //    }

            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Desenvolvedores/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Desenvolvedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Desenvolvedores/Create
        [HttpPost]
        public IActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Desenvolvedores/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaDesenvolvedorPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Desenvolvedores/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modDesenvolvedores dev)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        dev.idDev = id;
                    
            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View(dev);
            //    }
            //}

            return View();
            
        }

        // GET: Desenvolvedores/Delete/5
        public IActionResult Delete(int id)
        {
            //var model = _db.pubBuscaDesenvolvedorPorId(id);

            //return View(model);
            return View();
        }

        // POST: Desenvolvedores/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modDesenvolvedores dev)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        dev.idDev = id;
            //        _db.pubRemoveDesenvolvedor(dev);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        return View();
            //    }
            //}
            return View();
        }
    }
}
