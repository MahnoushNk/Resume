using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Presentation.Models;

using Resume.Domain.Model.Entitie.Expriences;
using Resume.Presentation.Models.Entities.ResumeDbContext;
using System.Diagnostics;
using Resume.Domain.Model.Entitie.MySkills;


namespace Resume.Domain.Controllers;

public class HomeController : Controller
{
    private readonly ResumeDbContext _context;

    public HomeController(ResumeDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        List<MySkill> mySkillsAsync = await _context.MySkills.ToListAsync();

        List<MySkill> mySkillsSynce =  _context.MySkills.ToList();

        List<Education> educationsAsync = await _context.Educations.ToListAsync();

        List<Education> educationsSynce =  _context.Educations.ToList();

        List<Exprience> expriencesAsync = await _context.Expriences.ToListAsync();

        List<Exprience> expriencesSynce = _context.Expriences.ToList();

       /* ViewBag.MySkills = mySkillsAsync;

        ViewBag.Expriences = expriencesAsync;  

        ViewBag.Educations = educationsAsync;*/


        return View();
    }

   
}