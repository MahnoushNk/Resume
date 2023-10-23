

using Resume.Domain.Entities.ContactUs;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Infrastructure.Repository;

public class ContactUsRepository : IContactUsRepository
{


	private readonly ResumeDbContext _Context;

	public ContactUsRepository(ResumeDbContext Context)
	{
		_Context = Context;
	}

	public async Task AddContactUsToTheDataBase(ContactUs contact)
	{
		await _Context.ContactUs.AddAsync(contact);
		await _Context.SaveChangesAsync();

	}
}
