using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ZheXian.Authorization;

namespace ZheXian
{
    [DependsOn(
        typeof(ZheXianCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZheXianApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZheXianAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZheXianApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
