using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class TipoDesenvolvimentoController : Controller
    {
        #region Lista todos os tipos de desenvolvimento cadastrados (View)
        // GET: TipoDesenvolvimento
        dalTipoDesenvolvimento _db = new dalTipoDesenvolvimento();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaTiposDesenvolvimento();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }
        #endregion

        // GET: TipoDesenvolvimento/Details/5
        public IActionResult Details(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubTipoDesenvolvimentoPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: TipoDesenvolvimento/Create
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

        // POST: TipoDesenvolvimento/Create
        [HttpPost]
        public IActionResult Create(modTipoDesenvolvimento tpDesenvolvimento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _db.pubCadastraTipoDesenvolvimento(tpDesenvolvimento);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(tpDesenvolvimento);
                }
            }
            return View();
            
        }

        // GET: TipoDesenvolvimento/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubTipoDesenvolvimentoPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: TipoDesenvolvimento/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modTipoDesenvolvimento tpDesenvolvimento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tpDesenvolvimento.idTipoDesenvolvimento = id;

                    _db.pubAtualizaTipoDesenvolvimento(tpDesenvolvimento);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(tpDesenvolvimento);
                }
            }

            return View();           
        }

        // GET: TipoDesenvolvimento/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubTipoDesenvolvimentoPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: TipoDesenvolvimento/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modTipoDesenvolvimento tpDesenvolvimento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    tpDesenvolvimento.idTipoDesenvolvimento = id;

                    _db.pubRemoveTipoDesenvolvimentoPorId(tpDesenvolvimento);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(tpDesenvolvimento);
                }
            }

            return View();          
        }
    }
}
