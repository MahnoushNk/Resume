

using Resume.Domain.Models.Entities.Educations;

namespace Resume.Domain.RepositoryInterface
{
	public interface IEducationRepository
	{
		//GetListOfEducations

		List<Education> GetListOfEducations();

	}
}
