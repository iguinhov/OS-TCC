using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dal;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebApp.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Default
        dalDepartamento _db = new dalDepartamento();
        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaDepartamentos();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // GET: Default/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Default/Create
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

        // POST: Default/Create
        [HttpPost]
        public IActionResult Create(modDepartamento departamento)
        {
            //try
            //{
            //    if (ModelState.IsValid)
            //    {
            //        _db.pubCadastraDepartamento(departamento);
            //    }           

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View(departamento);
            //}
            return View();
        }

        // GET: Default/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaDetalhesPorId(id);           

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, modDepartamento departamento)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     departamento.idDepartamento = id;
                    _db.pubAtualizaDepartamento(departamento);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(departamento);
                }               
            }
            return View();
        }

        // GET: Default/Delete/5
        public IActionResult Delete(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubBuscaDetalhesPorId(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, modDepartamento departamento)
        {
            if (ModelState.IsValid)
            {
                try
                {                
                    departamento.idDepartamento = id;

                    _db.pubRemoveDepartamentoPorId(id);

                    return RedirectToAction("Index");
                }
                
                catch
                {
                    return View(departamento);
                }            
            }
            return View();
        }
    }
}
