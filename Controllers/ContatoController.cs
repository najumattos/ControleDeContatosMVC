using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatosMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
