using GymSpec.DAO;
using GymSpec.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymSpec.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoDAO alunoDAO;
        public AlunoController(AlunoDAO alunoDAO)
        {
            this.alunoDAO = alunoDAO;
        }

        public ActionResult Adiciona(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                alunoDAO.Adiciona(aluno);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", aluno);
            }
        }

        public ActionResult Form()
        {
            return View();
        }

        // GET: Aluno
        public ActionResult Index()
        {
            return View(alunoDAO.Lista());
        }
    }
}