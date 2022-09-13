using FYD_s.Domain.Response;
using FYD_s.Domain.ViewModels.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FYD_s.Servece.Interfaces
{
    public interface IUserService
    {
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();

        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}
