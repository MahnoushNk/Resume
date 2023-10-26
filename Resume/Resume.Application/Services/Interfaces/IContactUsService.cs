

using Resume.Application.DTO.Siteside.ContactUs;
using Resume.Domain.Entities.ContactUs;

namespace Resume.Application.Services.Interfaces
{
	public interface IContactUsService
	{
		Task AddNewContactUsMessage(ContactUsDTO contactUsDTO);
	}
}
