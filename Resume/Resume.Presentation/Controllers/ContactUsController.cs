using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTO.Siteside.ContactUs;
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
		public async Task<IActionResult> ContactUs(ContactUsDTO contactUsDTO )
		{

			ContactUs contact = new ContactUs()
			{
				FullName = contactUsDTO.FullName,
				Massage = contactUsDTO.Massage,
				Mobile = contactUsDTO.Mobile,
			};

			ContactUsLocation location = new ContactUsLocation()
			{
				Address = contactUsDTO.Address,
			};

			await _contactUsRepository.AddContactUsToTheDataBase(contact);
			await _contactUsRepository.AddLocationToTheDataBase(location);
			return View();
		}
	}
}
