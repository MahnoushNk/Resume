using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class AdminController : Controller
    {
        #region Admin Dashboard

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

       

        #endregion

        #region List Of Usesr

        [HttpPost]
        public IActionResult ListOfUsers(string Email, string UserName)
        {
            return View();
        }

        #endregion
    }

}

