

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Infrastructure.Repository;

public class EducationRepository : IEducationRepository
{
	private readonly ResumeDbContext _context;

	public EducationRepository(ResumeDbContext context)
	{
		_context = context;
	}

    public async Task AddEducationTotDataBase(Education education)
    {
	await	_context.Educations.AddAsync(education);
      await _context.SaveChangesAsync();

    }

    public async Task DeleteAnEducation(Education education)
    {

        _context.Educations.Remove(education);
        await _context.SaveChangesAsync();
    }

    public  async Task EditAnEducation(Education education)
    {
        _context.Educations.Update(education);
      await  _context.SaveChangesAsync();
    }

    public  Task<Education> GetAnEducationByIdAsync(int educationId)
    {
       return _context.Educations.FirstOrDefaultAsync(e=> e.Id == educationId);
    }

    public List<Education> GetListOfEducations()
	{
		return _context.Educations.ToList();

	}
}
