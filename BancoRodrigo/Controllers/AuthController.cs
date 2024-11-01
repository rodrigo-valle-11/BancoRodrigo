using System.Web.Mvc;
using BancoRodrigo.Models;
using System.Linq; // Asegúrate de incluir este espacio de nombres


public class AuthController : Controller
{
    private readonly OracleDbContext _context = new OracleDbContext();

    [HttpGet]
    public ActionResult Login() => View();

    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        var user = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == username && u.Contraseña == password);
        if (user != null)
        {
            // Redirigir al área principal de la aplicación
            Session["UserId"] = user.IdUsuario;
            return RedirectToAction("Index", "Home");
        }
        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View();
    }

    [HttpGet]
    public ActionResult Register() => View();

    [HttpPost]
    public ActionResult Register(Usuario user)
    {
        if (ModelState.IsValid)
        {
            _context.Usuarios.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        return View(user);
    }
}
