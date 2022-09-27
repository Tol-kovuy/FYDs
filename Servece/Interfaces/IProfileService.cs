using FYD_s.Domain.Entity;
using FYD_s.Domain.Response;
using FYD_s.Domain.ViewModels.Profile;

namespace FYD_s.Servece.Interfaces
{
    public interface IProfileService
    {
        Task<BaseResponse<ProfileViewModel>> GetProfile(string userName);

        Task<BaseResponse<Profile>> Save(ProfileViewModel model);
    }
}
