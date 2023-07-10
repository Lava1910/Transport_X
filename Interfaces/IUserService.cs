using Transport_X.Requests.User;
using Transport_X.ViewModel;

namespace Transport_X.Interfaces
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        Task<UserViewModel> GetUserById(Guid userId);
        Task<Guid> Update(UserUpdateRequest request);
        Task<bool> ForgotPassword(ForgotPasswordRequest request);
    }
}
