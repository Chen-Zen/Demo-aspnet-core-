using Abp.AspNetCore.Mvc.ViewComponents;

namespace ZheXian.Web.Views
{
    public abstract class ZheXianViewComponent : AbpViewComponent
    {
        protected ZheXianViewComponent()
        {
            LocalizationSourceName = ZheXianConsts.LocalizationSourceName;
        }
    }
}
