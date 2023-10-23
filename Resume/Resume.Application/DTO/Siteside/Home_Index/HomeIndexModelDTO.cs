

using Resume.Domain.Model.Entitie.MySkills;

namespace Resume.Application.DTO.Siteside.Home_Index;

public class HomeIndexModelDTO
{
	public  List<Resume.Domain.Model.Entitie.MySkills.MySkill> MySkills { get; set; }

	public List<Resume.Domain.Model.Entitie.Expriences.Exprience> Expriences { get; set; }

	public List<Resume.Domain.Models.Entities.Educations.Education> Educations { get; set; }
}
