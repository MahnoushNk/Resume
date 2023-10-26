

using Resume.Application.DTO.Siteside.ContactUs;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation
{
	public class ContactUsService : IContactUsService
	{
		private readonly IContactUsRepository _contactUsRepository;
		public ContactUsService(IContactUsRepository contactUsRepository)
		{
			_contactUsRepository = contactUsRepository;
		}

		public async Task AddNewContactUsMessage(ContactUsDTO contactUsDTO)
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
		}
	}

		
}
