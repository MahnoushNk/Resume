using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTO.Siteside.ContactUs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{
		private readonly IContactUsService _contactUsService;
		public ContactUsController(IContactUsService contactUsService)
		{
			_contactUsService = contactUsService;
	
		}



		[HttpGet]
		public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost,ValidateAntiForgeryToken ]
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO)
		{
			if(ModelState.IsValid)
			{
				await _contactUsService.AddNewContactUsMessage(contactUsDTO);
				return RedirectToAction("Index", "Home");
			}
			
			return View();
		}
	}
}
