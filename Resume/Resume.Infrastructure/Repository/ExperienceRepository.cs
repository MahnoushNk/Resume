
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Model.Entitie.Expriences;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Infrastructure.Repository;

public class ExperienceRepository : IExperienceRepository
{
	private readonly ResumeDbContext _context;

	public ExperienceRepository(ResumeDbContext context)
	{
		_context = context;
	}

	public List<Exprience> GetListOfExperinces()
	{
		return _context.Expriences.ToList();
	}
}


