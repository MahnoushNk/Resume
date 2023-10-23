using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		public IActionResult ContactUs()
		{
			return View();
		}
	}
}
