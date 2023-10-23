

using Resume.Domain.Entities.ContactUs;

namespace Resume.Domain.RepositoryInterface
{
	public interface IContactUsRepository
	{
		Task AddContactUsToTheDataBase(ContactUs contact);
		Task AddLocationToTheDataBase(ContactUsLocation location);
	}
}
