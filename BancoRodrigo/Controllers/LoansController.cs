using System;
using System.Linq;
using System.Web.Mvc;
using BancoRodrigo.Models;

namespace BancoRodrigo.Controllers
{
    public class LoansController : Controller
    {
        private BancoRodrigoContext db = new BancoRodrigoContext();

        // GET: Loans
        public ActionResult Index()
        {
            var loans = db.Loans.ToList();
            return View(loans);
        }

        // GET: Loans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Loans/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Loan loan)
        {
            if (ModelState.IsValid)
            {
                loan.StartDate = DateTime.Now; // Establecer la fecha de inicio
                loan.EndDate = loan.StartDate.AddDays(loan.DurationDays); // Calcular la fecha de fin
                db.Loans.Add(loan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loan);
        }

        // Agregar otras acciones como Editar, Borrar, etc.
    }
}
