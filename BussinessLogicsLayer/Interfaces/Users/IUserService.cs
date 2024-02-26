using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.BLL.Interfaces.Users
{
    public interface IUserService
    {
        ValueTask<int> AddAsync(AddUserDto user);
        IEnumerable<User> GetAll();
    }
}
