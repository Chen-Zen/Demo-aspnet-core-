using System.Threading.Tasks;
using Abp.Application.Services;
using ZheXian.Sessions.Dto;

namespace ZheXian.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
