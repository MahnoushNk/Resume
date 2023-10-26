

using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation
{
	public class MySkillsService : IMySkillsService
	{
		private readonly IMySkillsRepository _mySkillsRepository;

		public MySkillsService(IMySkillsRepository mySkillsRepository)
		{
			_mySkillsRepository = mySkillsRepository;
		}

        public async Task AddMySkillToTheDatabase(MySkill skill)
        {
           await _mySkillsRepository.AddMySkillToTheDatabase(skill);
        }

        public async Task DeleteMySkill(MySkill myskill)
        {
            await _mySkillsRepository.DeleteMySkill(myskill);
        }

        public async Task EditMySkill(MySkill myskill)
        {
           await _mySkillsRepository.EditMySkill(myskill);
        }

        public List<MySkill> GetLIstOfMySkills()
		{
			return _mySkillsRepository.GetLIstOfMySkills();
		}

        public async Task<MySkill> GetMySkillByIdAsync(int mySkillId)
        {
           return await _mySkillsRepository.GetMySkillByIdAsync(mySkillId);
        }
    }
}
