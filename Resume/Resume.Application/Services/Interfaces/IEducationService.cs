

using Resume.Application.DTO.AdminSide.Education;
using Resume.Domain.Models.Entities.Educations;

namespace Resume.Application.Services.Interfaces
{
	public interface IEducationService
	{
		List<Education> GetListOfEducations();

		List<ListOfEducationsAdminSideDTO> GetListOfEducationsAdminPanel();

		Task AddEducationToDataBase(CreateAnEducationAdminSideDTO model);

		Task<Education>  GetAnEducationByIdAsync(int Id);

		Task EditAnEducation(Education education);
        Task DeleteAnEducation(Education education);




    }


}
