using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTO.AdminSide.Education;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;

[Area("AdminPanel")]
public class ExperienceController : Controller
{
    private readonly IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    #region Get List Of Experiences
    [HttpGet]
    public IActionResult ListOfExperiences()
    {
      var experience =  _experienceService.GetListOfExperineces();
        return View(experience);
    }

    #endregion

    #region Create An Experience

    public IActionResult CreateExperience()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateExperience(Exprience exprience)
    {
        await _experienceService.AddExperienceToTheDatabase(exprience);
        return RedirectToAction(nameof(ListOfExperiences));
    }

    #endregion
    #region Edit An Experience

    [HttpGet]
    public async Task<IActionResult> EditAnExprience(int exprienceId)
    {
        #region Get An Experience By Id

        var exprience = await _experienceService.GetAnExprienceById(exprienceId);

        #endregion
        return View(exprience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAnExprience(Exprience exprience)
    {
        #region Update An Experience By Id

        await _experienceService.EditAnExprience(exprience);

        return RedirectToAction(nameof(ListOfExperiences));

        #endregion

        return View(exprience);

    }


    #endregion

    #region Delete An Exprience

    [HttpGet]
    public async Task<IActionResult>DeleteAnExprience(int exprienceId)
    {
        #region Get An Experience By Id

        var exprience = await _experienceService.GetAnExprienceById(exprienceId);

        #endregion
        return View(exprience);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAnExprience(Exprience exprience)
    {
        #region Update An Experience By Id

        await _experienceService.DeleteAnExprience(exprience);

        return RedirectToAction(nameof(ListOfExperiences));

        #endregion

        return View(exprience);

    }


    #endregion


}

