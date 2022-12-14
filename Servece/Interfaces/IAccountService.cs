using FYD_s.Domain.Response;
using FYD_s.Domain.ViewModels.Account;

namespace FYD_s.Service.Interfaces
{
    public interface IAccountService
    {
        BaseResponse<ClaimsIdentity> Register(RegisterViewModel model);

        BaseResponse<ClaimsIdentity> Login(LoginViewModel model);
        BaseResponse<bool> ChangePassword(ChangePasswordViewModel model);
    }
}
