

using Resume.Domain.Models.Entities.Educations;

namespace Resume.Domain.RepositoryInterface
{
	public interface IEducationRepository
	{
		List<Education> GetListOfEducations();

		Task  AddEducationTotDataBase(Education education);

        Task<Education> GetAnEducationByIdAsync(int educationId);

        Task EditAnEducation(Education education);

		Task DeleteAnEducation(Education education);





    }
}
