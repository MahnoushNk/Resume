using Microsoft.AspNetCore.Mvc;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Presentation.Controllers
{
	public class ContactUsController : Controller
	{

		private readonly IContactUsRepository _contactUsRepository;
		public	ContactUsController(IContactUsRepository contactUsRepository)
		{
			_contactUsRepository = contactUsRepository;
		}
		[HttpGet]
		public IActionResult ContactUs()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ContactUs(string FullName, string Mobile, string Massage)
		{
			ContactUs model = new ContactUs()
			{
				FullName = FullName,
				Mobile = Mobile,
				Massage = Massage,
				CreateDate = DateTime.Now,
				IsSeeenByAdnmin = false

			};

			await _contactUsRepository.AddContactUsToTheDataBase(model);

			return View();
		}
	}
}
