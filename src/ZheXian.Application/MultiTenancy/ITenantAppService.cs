using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ZheXian.MultiTenancy.Dto;

namespace ZheXian.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
