using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Implementation;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;

namespace Resume.Presentation.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;
        public EducationController(EducationService educationService)
        {
           _educationService = educationService;
        }
       

        public async Task<IActionResult> ListOfEducations()
        {
           
            return View();
        
        }

        public async Task<IActionResult> CreateAnEducation() 
        { 
          
            return RedirectToAction(nameof(ListOfEducations));
        }

        public async Task<IActionResult> DeleteAnEducation(int educationId )
        {
            

            return RedirectToAction(nameof(ListOfEducations));
        }
    }
}

