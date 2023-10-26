

using Resume.Application.DTO.Siteside.Home_Index;

namespace Resume.Application.Services.Interfaces
{
	public interface IDashboardService
	{
		Task<HomeIndexModelDTO> FillDashboardModel();
	}
}
