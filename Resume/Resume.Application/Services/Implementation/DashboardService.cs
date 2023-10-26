

using Resume.Application.DTO.Siteside.Home_Index;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implementation
{
	public class DashboardService : IDashboardService
	{

		private readonly IEducationService _educationService;

		private readonly IExperienceService _experienceService;

		private readonly IMySkillsService _mySkillsService;

		public DashboardService(IEducationService educationService,
			                    IExperienceService experienceService,
							    IMySkillsService mySkillsService)
							 
		{
			_educationService = educationService;
			_experienceService = experienceService;
			_mySkillsService = mySkillsService;
			


		}

		public async Task<HomeIndexModelDTO> FillDashboardModel()
		{

			List<MySkill> mySkills =  _mySkillsService.GetLIstOfMySkills();

			List<Education> educations = _educationService.GetListOfEducations();

			List<Exprience> expriences = _experienceService.GetListOfExperineces();




			HomeIndexModelDTO model = new HomeIndexModelDTO();

			model.Educations = educations;

			model.Expriences = expriences;

			model.MySkills = mySkills;

			return model;

		}
	}
}
