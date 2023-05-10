using Microsoft.AspNetCore.Mvc;

namespace WebApp_Manha.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
