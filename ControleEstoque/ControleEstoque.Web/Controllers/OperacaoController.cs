﻿using System.Web.Mvc;

namespace ControleEstoque.Web.Controllers
{
    public class OperacaoController : Controller
    {
        public ActionResult EntradaEstoque()
        {
            return View();
        }

        public ActionResult SaidaEstoque()
        {
            return View();
        }

        public ActionResult LancamentoPerdaProduto()
        {
            return View();
        }

        public ActionResult Inventario()
        {
            return View();
        }
    }
}