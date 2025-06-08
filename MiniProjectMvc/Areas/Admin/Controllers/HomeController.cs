using Microsoft.AspNetCore.Mvc;

namespace MiniProjectMvc.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
