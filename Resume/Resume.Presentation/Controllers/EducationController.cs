using Microsoft.AspNetCore.Mvc;
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

        public IActionResult ListOfEducations()
        { 
            List<Education> listOfEducation = _context.Educations.ToList();

            Education education = _context.Educations.OrderByDescending(p=> p.Id).First();
            return View();
        
        }

        public IActionResult CreateAnEducation() 
        { 
            Education educationDatabase = new Education()
            {
              
                EducationTitle = "Master",
                EducationDuration = "2024-2026",
                Description = "Description"
            };
          
            _context.Educations.Add(educationDatabase);
            _context.SaveChanges();

            return View();
        }
    }
}

