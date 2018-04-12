using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ZheXian.Configuration.Dto;

namespace ZheXian.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZheXianAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
