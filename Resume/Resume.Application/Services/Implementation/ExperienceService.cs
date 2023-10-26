

using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;

namespace Resume.Application.Services.Implementation
{
	public class ExperienceService : IExperienceService
	{
		private readonly IExperienceRepository _experienceRepository;
		public ExperienceService(IExperienceRepository experienceRepository)
		{
			_experienceRepository = experienceRepository;
		}

        public async Task AddExperienceToTheDatabase(Exprience exprience)
        {
			await _experienceRepository.AddExperienceToTheDatabase(exprience);
		
        }

        public async Task DeleteAnExprience(Exprience exprience)
        {
            await _experienceRepository.DeleteAnExprience(exprience);
        }

        public async Task EditAnExprience(Exprience exprience)
        {
            await _experienceRepository.EditAnExprience(exprience);
        }

        public async Task<Exprience> GetAnExprienceById(int exprienceId)
        {
            return await _experienceRepository.GetAnExprienceByIdAsync(exprienceId);
        }

        public List<Exprience> GetListOfExperineces()
		{
			return _experienceRepository.GetListOfExperineces();
		}
	}
}
