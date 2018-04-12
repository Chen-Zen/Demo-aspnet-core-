using System.Threading.Tasks;
using Abp.Application.Services;
using ZheXian.Authorization.Accounts.Dto;

namespace ZheXian.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
