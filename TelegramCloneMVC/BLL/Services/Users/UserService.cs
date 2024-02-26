using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.BLL.Interfaces.Users;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.BLL.Services.Users
{
    public class UserService : IUserService
    {
        public ValueTask<AddUserDto> AddAsync(AddUserDto user)
        {

        }

        public ValueTask<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
