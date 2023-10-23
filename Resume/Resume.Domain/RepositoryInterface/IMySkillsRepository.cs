

using Resume.Domain.Model.Entitie.MySkills;

namespace Resume.Domain.RepositoryInterface
{
	public interface IMySkillsRepository
	{
		//GetLIstOfMySkills

		List<MySkill> GetLIstOfMySkills();
	}
}
