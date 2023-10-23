

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Model.Entitie.MySkills;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Infrastructure.Repository;

public class MySkillsRepository : IMySkillsRepository
{
	private readonly ResumeDbContext _context;

	public MySkillsRepository(ResumeDbContext context)
	{
		_context = context;
	}

	public List<MySkill> GetLIstOfMySkills()
	{
		return _context.MySkills.ToList();
	}
}
