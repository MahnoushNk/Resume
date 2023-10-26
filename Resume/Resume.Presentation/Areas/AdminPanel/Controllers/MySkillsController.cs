using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Presentation.Areas.AdminPanel.Controllers;
[Area("AdminPanel")]
public class MySkillsController : Controller
{
    #region Ctor
    private readonly IMySkillsService _mySkillsService;

    public MySkillsController(IMySkillsService mySkillsService)
    {
        _mySkillsService = mySkillsService;
    }
    #endregion

    public IActionResult ListOfMySkills()
    {
        var skills = _mySkillsService.GetLIstOfMySkills();

        return View(skills);
    }

    #region Create An MySkill

    public IActionResult CreateMySkill()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateMySkill(MySkill mySkill)
    {
        await _mySkillsService.AddMySkillToTheDatabase(mySkill);
        return RedirectToAction(nameof(ListOfMySkills));
    }



    #endregion

    #region Edit An Myskill

    public async Task<IActionResult> EditMySkill(int mySkillId)
    {
        var mySkill = await _mySkillsService.GetMySkillByIdAsync(mySkillId);
        return View(mySkill);
    }

    [HttpPost,ValidateAntiForgeryToken]
    public async Task<IActionResult> EditMySkill(MySkill mySkill)
    { await _mySkillsService.EditMySkill(mySkill);

        return RedirectToAction(nameof(ListOfMySkills));

        return View(mySkill);
    }

    #endregion

    #region Delete an MySkill
    public async Task<IActionResult> DeleteMySkill(int mySkillId)
    {
        var mySkill = await _mySkillsService.GetMySkillByIdAsync(mySkillId);
        return View(mySkill);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteMySkill(MySkill mySkill)
    {
        await _mySkillsService.DeleteMySkill(mySkill);

        return RedirectToAction(nameof(ListOfMySkills));

        return View(mySkill);
    }

    #endregion

}
