using Resume.Domain.Models.Entities.Educations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
   public interface IEducationService
    {
       Task<List<Education>> GetListOfEducationsAsync();
        List<Education> GetListOfEducations();

        Task CreateAnEducationAsync(Education education);
        void CreateAnEducation(Education education);

        Task DeleteAnEducationAsync(int eucationId);

        void DeleteAnEducation(int eucationId);

        Task<Education>  GetAnEducationByIdAsync (int eucationId);
        Education GetAnEducationById(int eucationId);
    }
}
    
