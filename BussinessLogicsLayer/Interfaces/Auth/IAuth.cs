using BusinessLogicsLayer.DTOs.Users;

namespace BusinessLogicsLayer.Interfaces.Auth
{
    public interface IAuth
    {
        ValueTask<int> Register(AddUserDto dto);
        ValueTask<int> LogIn(AddUserDto dto);
    }
}
