using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Resume.Presentation.Models.Entities.Educations;
using Resume.Presentation.Models.Entities.ResumeDbContext;

namespace Resume.Presentation.Controllers
{
    public class EducationController : Controller
    {

        #region Ctor
        ResumeDbContext _dbcontext = new ResumeDbContext();

        private ResumeDbContext _context;
        public EducationController(ResumeDbContext context )
        {
            _context = context;
        }
        #endregion

        public async Task<IActionResult> ListOfEducations()
        { 
            List<Education> education = await _context.Educations.ToListAsync();

            return View();
        
        }

        public async Task<IActionResult> CreateAnEducation() 
        { 
            Education education = new Education();
            education.EducationDuration = "";
            education.EducationTitle = "Title";
            education.Description   = "Description";

            await _context.Educations.AddAsync(education);
            await _context.SaveChangesAsync();
             
            

            return RedirectToAction(nameof(ListOfEducations));
        }

        public async Task<IActionResult> DeleteAnEducation()
        {
            
            Education? education2 = await _context.Educations.FirstOrDefaultAsync(p => p.Id == 31);
            _context.Educations.Remove(education2); 
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ListOfEducations));
        }
    }
}

