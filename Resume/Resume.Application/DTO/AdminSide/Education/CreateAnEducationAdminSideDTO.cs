

using System.ComponentModel.DataAnnotations;

namespace Resume.Application.DTO.AdminSide.Education;

public class CreateAnEducationAdminSideDTO
{
    [Required]
    public int Id { get; set; }
    public string EducationTitle { get; set; }
    public string EducationDuration { get; set; }
    public string Description { get; set; }
}
