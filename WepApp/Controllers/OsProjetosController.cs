using System;
using System.Linq;
using Model;
using Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
    public class OsProjetosController : Controller
    {
        // GET: OsProjetos
        dalProjetoEmDesenvolvimento _db = new dalProjetoEmDesenvolvimento();
        //private DB_OS_SISTEMASEntities dbContext = new DB_OS_SISTEMASEntities();

        public IActionResult Index()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaTodosOsDesenvolvimento();

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        //GET: Detalhes de itens por Ordem de serviço / Lista (Collection)
        public IActionResult Details(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{

            //    var model = _db.pubListaItensAtreladosNaOrdemdeServico(id);

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }    

        // GET: OsProjetos/Create
        public IActionResult Create()
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    ViewBag.Projeto = new SelectList(dbContext.TB_PROJETOS_SISTEMAS, "ID_PROJETO", "NOME_PROJETO");

            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: OsProjetos/Create
        [HttpPost]
        public IActionResult Create(modProjetoEmDesenvolvimento ordemServico)
        {           
               //if (ModelState.IsValid)
               // {
               //     try
               //     {
               //         ordemServico.dtCadastro = DateTime.Now;
               //         _db.pubCadastraNovoProjeto(ordemServico);

               //         return RedirectToAction("Index");
               //     }
               //     catch
               //     {
               //         ViewBag.Projeto = new SelectList(dbContext.TB_PROJETOS_SISTEMAS, "ID_PROJETO", "NOME_PROJETO", ordemServico.idProjeto);
               //         return View(ordemServico);
               //     }
               // }
                return View();           
        }

        // GET: OsProjetos/Edit/5
        public IActionResult Edit(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    ViewBag.Projeto = new SelectList(dbContext.TB_PROJETOS_SISTEMAS, "ID_PROJETO", "NOME_PROJETO");

            //    var model = _db.pubBuscaOsProjetoPorId(id);            

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        // POST: OsProjetos/Edit/5
        [HttpPost]
        public IActionResult Edit(int id,modProjetoEmDesenvolvimento ordemServico)
        {
            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        ordemServico.idNmSolitacao = id;
            //        ordemServico.idUsuarioLogado = Session["NomeLogin"].ToString();

            //        _db.pubAtualizaFinalizaProjetoEmDesenvolvimento(ordemServico);

            //        return RedirectToAction("Index");
            //    }
            //    catch
            //    {
            //        ViewBag.Projeto = new SelectList(dbContext.TB_PROJETOS_SISTEMAS, "ID_PROJETO", "NOME_PROJETO", ordemServico.idProjeto);

            //        return View(ordemServico);
            //    }
            //}
            return View();
            
        }

        // GET: OsProjetos/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: OsProjetos/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, FormCollection collection)
        {
            //try
            //{
            //    // TODO: Add delete logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
            return View();
        }

        public IActionResult ListaItensDaOs(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaItensAtreladosNaOrdemdeServico(id);              

            //    var combo = _db.pubComboListaProjetosEmDesenvolvimento().ToList();        

            //    ViewBag.ComboSeleciona = new SelectList(combo, "idNmSolitacao", "nomeProjeto");

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }

        //LISTA TODOS OS ITENS DE PROJETOS FINALIZADOS PARA VER DETALHES
        public IActionResult ListaItensDaOsFinalizada(int id)
        {
            //if (Session["NomeLogin"] != null)
            //{
            //    var model = _db.pubListaItensAtreladosNaOrdemdeServico(id);           

            //    return View(model);
            //}
            //else
            //{
            //    return RedirectToAction("Logar", "Usuario");
            //}
            return View();
        }
    }
}
