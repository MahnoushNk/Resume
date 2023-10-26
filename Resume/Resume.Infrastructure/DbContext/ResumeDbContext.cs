using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.Models.Entities.Educations;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.Models.Entities.Expriences;
using Resume.Domain.Entities.ContactUs;

namespace Resume.Presentation.Models.Entities.ResumeDbContext;

public class ResumeDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-R8LD9GE;Initial Catalog=ResumeDaneshkar;Integrated Security=True;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
  public DbSet<Exprience> Expriences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<MySkill> MySkills { get; set; }
   public DbSet<ContactUs> ContactUs { get; set; }

    public DbSet<ContactUsLocation> locations { get; set; }

}
