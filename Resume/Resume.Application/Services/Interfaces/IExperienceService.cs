
using Resume.Domain.Models.Entities.Expriences;

namespace Resume.Application.Services.Interfaces
{
	public interface IExperienceService
	{
		List<Exprience> GetListOfExperineces();

        Task AddExperienceToTheDatabase(Exprience exprience);

        Task<Exprience> GetAnExprienceById(int exprienceId);

        Task EditAnExprience(Exprience exprience);

        Task DeleteAnExprience(Exprience exprience);
    }
}
