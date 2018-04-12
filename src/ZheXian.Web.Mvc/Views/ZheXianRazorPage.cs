using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ZheXian.Web.Views
{
    public abstract class ZheXianRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ZheXianRazorPage()
        {
            LocalizationSourceName = ZheXianConsts.LocalizationSourceName;
        }
    }
}
