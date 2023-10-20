namespace Resume.Presentation.Models.Entities.Expriences;

public class Exprience
{

    public int Id { get; set; }
    public string ExprienceTitle { get; set; }
    public string ExprienceDuration { get; set; }
    public string Description { get; set; }
    public string CompanyName   { get; set; }
    public string? CompanySite { get; set; }
}
