using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.BLL.Interfaces.Users
{
    public interface IUserService
    {
        ValueTask<AddUserDto> AddAsync(AddUserDto user);
        ValueTask<IEnumerable<User>> GetAll();
    }
}
