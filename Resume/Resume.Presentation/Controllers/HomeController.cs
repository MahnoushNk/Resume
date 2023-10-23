using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Presentation.Models;

using Resume.Domain.Model.Entitie.Expriences;
using Resume.Presentation.Models.Entities.ResumeDbContext;
using System.Diagnostics;
using Resume.Domain.Model.Entitie.MySkills;
using Resume.Application.DTO.Siteside.Home_Index;
using Resume.Domain.RepositoryInterface;

namespace Resume.Domain.Controllers;

public class HomeController : Controller
{
	private readonly IEducationRepository _educationRepository;

	private readonly IMySkillsRepository _mySkillsRepository;

	private readonly IExperienceRepository _experienceRepository;

	public HomeController(IEducationRepository educationRepository,
						  IMySkillsRepository mySkillsRepository,
						  IExperienceRepository experienceRepository)
	{
		_educationRepository = educationRepository;
		_mySkillsRepository = mySkillsRepository;
		_experienceRepository = experienceRepository;


	}

	public async Task<IActionResult> Index()
	{
		List<MySkill> mySkills = _mySkillsRepository.GetLIstOfMySkills();

		List<Education> educations = _educationRepository.GetListOfEducations();

		List<Exprience> expriences = _experienceRepository.GetListOfExperinces();

		

		/* ViewBag.MySkills = mySkillsAsync;

         ViewBag.Expriences = expriencesAsync;  

         ViewBag.Educations = educationsAsync;*/

		HomeIndexModelDTO model = new HomeIndexModelDTO();

		model.Educations = educations;

		model.Expriences = expriences;

		model.MySkills = mySkills;



		return View(model);
	}


}