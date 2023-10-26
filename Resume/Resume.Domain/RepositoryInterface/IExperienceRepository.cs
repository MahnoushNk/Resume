﻿

using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Domain.RepositoryInterface
{
	public interface IExperienceRepository
	{
		List<Exprience> GetListOfExperineces();

        Task AddExperienceToTheDatabase(Exprience exprience);

        Task<Exprience> GetAnExprienceByIdAsync(int exprienceId);

        Task EditAnExprience(Exprience exprience);

        Task DeleteAnExprience(Exprience exprience);




    }
}
