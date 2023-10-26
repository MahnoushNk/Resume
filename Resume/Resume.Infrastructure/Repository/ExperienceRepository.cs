
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.Expriences;
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

    public async Task AddExperienceToTheDatabase(Exprience exprience)
    {
      await _context.Expriences.AddAsync(exprience);
	 await	_context.SaveChangesAsync();
    }

    public async Task DeleteAnExprience(Exprience exprience)
    {
        _context.Expriences.Remove(exprience);
        await _context.SaveChangesAsync();
    }

    public async Task EditAnExprience(Exprience exprience)
    {
        _context.Expriences.Update(exprience);
        await _context.SaveChangesAsync();
    }

   

    public Task<Exprience> GetAnExprienceByIdAsync(int exprienceId)
    {
        return _context.Expriences.FirstOrDefaultAsync(p => p.Id == exprienceId);
    }

    public List<Exprience> GetListOfExperineces()
	{
		return _context.Expriences.ToList();
	}
}


