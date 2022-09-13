using System.Security.Claims;
using System.Threading.Tasks;
using FYD_s.Domain.Response;
using FYD_s.Domain.ViewModels.Account;

namespace FYD_s.Service.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
    }
}
