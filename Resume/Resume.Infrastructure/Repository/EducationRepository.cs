

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Infrastructure.Repository
{
	public class EducationRepository : IEducationRepository
	{
		private readonly ResumeDbContext _context;

		public EducationRepository(ResumeDbContext context)
		{
			_context = context;
		}

		public List<Education> GetListOfEducations()
		{
			return _context.Educations.ToList();

		}
	}
}
