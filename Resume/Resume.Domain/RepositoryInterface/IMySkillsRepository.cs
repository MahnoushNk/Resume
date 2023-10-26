﻿

using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
	public interface IMySkillsRepository
	{
		List<MySkill> GetLIstOfMySkills();

		Task AddMySkillToTheDatabase(MySkill skill);
		Task<MySkill> GetMySkillByIdAsync(int mySkillId);

		Task EditMySkill(MySkill mySkill);

        Task DeleteMySkill(MySkill mySkill);
    }
}
