using GymSpec.DAO;
using GymSpec.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymSpec.Controllers
{
    public class PagamentoController : Controller
    {
        private PagamentoDAO pagamentoDAO;
        private AlunoDAO alunoDAO;

        public PagamentoController(PagamentoDAO pagamentoDAO, AlunoDAO alunoDAO)
        {
            this.pagamentoDAO = pagamentoDAO;
            this.alunoDAO = alunoDAO;
        }

        public ActionResult Adiciona(Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                pagamentoDAO.Adiciona(pagamento);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Alunoes = alunoDAO.Lista();
                return View("Form");
            }
        }

        public ActionResult Form()
        {
            ViewBag.Alunoes = alunoDAO.Lista();
            return View();
        }

        // GET: Pagamento
        public ActionResult Index()
        {
            return View(pagamentoDAO.Lista());
        }
    }
}