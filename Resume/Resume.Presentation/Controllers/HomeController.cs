using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models;
using Resume.Presentation.Models.Entities.ResumeDbContext;
using System.Diagnostics;

namespace Resume.Presentation.Controllers;

public class HomeController : Controller
{
    private readonly ResumeDbContext _context;

    public HomeController(ResumeDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var mySkillsAsync = await _context.MySkills.ToListAsync();
        var mySkillssynce =  _context.MySkills.ToList();
        return View();
    }

   
}