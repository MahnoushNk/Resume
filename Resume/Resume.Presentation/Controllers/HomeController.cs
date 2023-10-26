using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Presentation.Models;

using Resume.Domain.Models.Entities.Expriences;
using Resume.Presentation.Models.Entities.ResumeDbContext;
using System.Diagnostics;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Application.DTO.Siteside.Home_Index;
using Resume.Domain.RepositoryInterface;
using Resume.Application.Services.Interfaces;

namespace Resume.Domain.Controllers;

public class HomeController : Controller
{
	private readonly IDashboardService _dashboardService;
	public HomeController(IDashboardService dashboardService)
	{
		_dashboardService = dashboardService;
		
	}

	public async Task<IActionResult> Index()
	{
		var model = await _dashboardService.FillDashboardModel();

		return View(model);
	}


}