using Microsoft.AspNetCore.Mvc;
using Resume.Application.DTO.AdminSide.Education;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;
[Area("AdminPanel")]
public class EducationController : Controller
{
    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    #region List Of Education
    [HttpGet]
    public IActionResult ListOfEducations()
    {
        var model = _educationService.GetListOfEducations();
        return View(model);
    }

    #endregion

    #region Create An Education
    public IActionResult CreateAnEducation()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateAnEducation(CreateAnEducationAdminSideDTO model)
    {
        if (ModelState.IsValid)
        {
            //Add Education to the database

           await _educationService.AddEducationToDataBase(model);
        }

        return RedirectToAction(nameof(ListOfEducations));
    }
    #endregion

    #region Edit An Education

    [HttpGet]
     public async Task<IActionResult> EditAnEducation(int educationId)
    {
        #region Get An Education By Id

        var education = await _educationService.GetAnEducationByIdAsync(educationId); 

        #endregion
        return View(education);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAnEducation(Education education)
    {
        #region Update An Education By Id

       await _educationService.EditAnEducation(education);
       
        return RedirectToAction(nameof(ListOfEducations));

        #endregion

        return View(education);

    }


    #endregion

    #region Delete an Education

    [HttpGet]
    public async Task<IActionResult> DeleteAnEducation(int educationId)
    {
        #region Get An Education By Id

        var education = await _educationService.GetAnEducationByIdAsync(educationId);

        #endregion
        return View(education);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteAnEducation(Education education)
    {
        #region Update An Education By Id

        await _educationService.DeleteAnEducation(education);

        return RedirectToAction(nameof(ListOfEducations));

        return View(education);

        #endregion

    }

    #endregion

}
