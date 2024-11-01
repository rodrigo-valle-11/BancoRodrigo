using System;
using System.Linq;
using System.Web.Mvc;
using BancoRodrigo.Models;

namespace BancoRodrigo.Controllers
{
    public class InvestmentsController : Controller
    {
        private BancoRodrigoContext db = new BancoRodrigoContext();

        // GET: Investments
        public ActionResult Index()
        {
            var investments = db.Investments.ToList();
            return View(investments);
        }

        // GET: Investments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Investments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Investment investment)
        {
            if (ModelState.IsValid)
            {
                investment.StartDate = DateTime.Now; // Establecer la fecha de inicio
                investment.EndDate = investment.StartDate.AddDays(investment.DurationDays); // Calcular la fecha de fin
                db.Investments.Add(investment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(investment);
        }

        // Agregar otras acciones como Editar, Borrar, etc.
    }
}
