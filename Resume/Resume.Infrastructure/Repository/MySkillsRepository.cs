

using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.MySkills;
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

    public async  Task AddMySkillToTheDatabase (MySkill skill)
    {
      await _context.MySkills.AddAsync(skill);
		await _context.SaveChangesAsync();
    }

    public async Task DeleteMySkill(MySkill mySkill)
    {
        _context.MySkills.Remove(mySkill);
      await  _context.SaveChangesAsync();
    }

    public async Task EditMySkill(MySkill mySkill)
    {
       _context.MySkills.Update(mySkill);
      await  _context.SaveChangesAsync();
    }

    public List<MySkill> GetLIstOfMySkills()
	{
		return _context.MySkills.ToList();
	}

    public Task<MySkill> GetMySkillByIdAsync(int mySkillId)
    {
        return _context.MySkills.FirstOrDefaultAsync(s => s.Id == mySkillId);
    }
}
