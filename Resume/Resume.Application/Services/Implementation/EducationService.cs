

using Resume.Application.DTO.AdminSide.Education;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation
{
	public class EducationService : IEducationService
	{
		private readonly IEducationRepository _educationRepository;

		public EducationService(IEducationRepository educationRepository)
		{
			_educationRepository = educationRepository;
	
		}

        public async Task AddEducationToDataBase(CreateAnEducationAdminSideDTO model)
        {
            #region ObjectMapping

			Education education = new Education();

			education.EducationTitle = model.EducationTitle;
			education.EducationDuration = model.EducationDuration;
			education.Description = model.Description;

            #endregion

            #region Add Education To DataBase

		 await	_educationRepository.AddEducationTotDataBase(education);
			
            #endregion


        }

        public async Task DeleteAnEducation(Education education)
        {
            await _educationRepository.DeleteAnEducation(education);
        }

        public async Task EditAnEducation(Education education)
        {
          await  _educationRepository.EditAnEducation(education);
        }

        public async Task<Education> GetAnEducationByIdAsync(int educationId)
        {
            return await _educationRepository.GetAnEducationByIdAsync(educationId);
        }

        public List<Education> GetListOfEducations()
		{
			return _educationRepository.GetListOfEducations();
		}

		public List<ListOfEducationsAdminSideDTO> GetListOfEducationsAdminPanel()

		{
			#region  Get List Of Educations From Database

			List<Education> educations = _educationRepository.GetListOfEducations();

			#endregion

			#region Objact Mapping 

			List<ListOfEducationsAdminSideDTO> returnModel = new List<ListOfEducationsAdminSideDTO>();

			foreach (var edu in educations)
			{
				ListOfEducationsAdminSideDTO childModel = new ListOfEducationsAdminSideDTO();

				childModel.EducationTitle = edu.EducationTitle;
				childModel.Id = edu.Id;
				childModel.Duration = edu.EducationDuration;

				returnModel.Add(childModel);
			}

			#endregion


			return returnModel;
		}
	}
}
