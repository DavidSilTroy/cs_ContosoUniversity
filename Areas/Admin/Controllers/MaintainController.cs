using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Areas.Admin.Controllers
{
    public class MaintainController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
