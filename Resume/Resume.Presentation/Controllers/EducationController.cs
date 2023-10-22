using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Educations;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Presentation.Controllers
{
    public class EducationController : Controller
    {

        public EducationController()
        {
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
            
            Education? education = await _context.Educations.FirstOrDefaultAsync(p => p.Id == educationId);
            _context.Educations.Remove(education); 
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfEducations));
        }
    }
}

