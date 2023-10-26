

using Resume.Domain.Models.Entities.MySkills;

namespace Resume.Application.DTO.Siteside.Home_Index;

public class HomeIndexModelDTO
{
	public  List<Resume.Domain.Models.Entities.MySkills.MySkill> MySkills { get; set; }

	public List<Resume.Domain.Models.Entities.Expriences.Exprience> Expriences { get; set; }

	public List<Resume.Domain.Models.Entities.Educations.Education> Educations { get; set; }
}
