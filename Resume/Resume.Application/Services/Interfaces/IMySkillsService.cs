
using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Application.Services.Interfaces
{
	public interface IMySkillsService
	{
		List<MySkill> GetLIstOfMySkills();
		Task AddMySkillToTheDatabase(MySkill skill);

		Task<MySkill> GetMySkillByIdAsync(int mySkillId);

		Task EditMySkill(MySkill myskill);

        Task DeleteMySkill(MySkill myskill);

    }
}
