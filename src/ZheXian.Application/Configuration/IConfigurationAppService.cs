using System.Threading.Tasks;
using ZheXian.Configuration.Dto;

namespace ZheXian.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
