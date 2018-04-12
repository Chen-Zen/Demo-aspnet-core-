using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZheXian.Configuration;

namespace ZheXian.Web.Host.Startup
{
    [DependsOn(
       typeof(ZheXianWebCoreModule))]
    public class ZheXianWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ZheXianWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZheXianWebHostModule).GetAssembly());
        }
    }
}
