using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
