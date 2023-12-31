﻿using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.Entities.Educations;
using Resume.Presentation.Models.Entities.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Resume.Application.Services.Implementation
{
   public class EducationService : IEducationService
    {

        #region Ctor


        private ResumeDbContext _context;
      
        public EducationService(ResumeDbContext context)
        {
            _context = context;

        }
        #endregion

        public async Task<List<Education>> GetListOfEducationsAsync()
        {
            List<Education> education = await _context.Educations.ToListAsync();

            return education;
        }
        public  List<Education> GetListOfEducations()
        {
            List<Education> education =  _context.Educations.ToList();

            return education;
        }

       public async Task CreateAnEducationAsync(Education education)
        {
            Education education1 = new Education();
            education.EducationDuration = "";
            education.EducationTitle = "Title";
            education.Description = "Description";

            await _context.Educations.AddAsync(education1);
            await _context.SaveChangesAsync();
        }
        public void CreateAnEducation(Education education)
        {
            Education education1 = new Education();
            education.EducationDuration = "";
            education.EducationTitle = "Title";
            education.Description = "Description";

             _context.Educations.Add(education1);
             _context.SaveChanges();
        }
         public async Task  DeleteAnEducationAsync(int educationId)
        {
            Education education = await GetAnEducationByIdAsync(educationId);
          
          _context.Educations.Remove(education);
            await _context.SaveChangesAsync();
            
        }

       public void DeleteAnEducation(int educationId)
        {

            Education education =  GetAnEducationById(educationId);


            _context.Educations.Remove(education);
             _context.SaveChanges();
        }

        public async Task<Education> GetAnEducationByIdAsync(int educationId)
        {

            Education? education = _context.Educations.FirstOrDefault(p => p.Id == educationId);

            if (education == null) return null;

            return education;
        }
            
       public Education GetAnEducationById(int educationId)
        {

            Education? education = _context.Educations.FirstOrDefault(p => p.Id == educationId);

            return education;
        }
    }
}

