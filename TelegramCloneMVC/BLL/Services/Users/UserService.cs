using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.BLL.Interfaces.Users;
using TelegramCloneMVC.Data.Entities.Users;
using TelegramCloneMVC.Data.Interfaces;

namespace TelegramCloneMVC.BLL.Services.Users
{
    public class UserService(IUnitOfWork unitOfWork) : IUserService
    {
        public IUnitOfWork _dbService = unitOfWork;
        public ValueTask<AddUserDto> AddAsync(AddUserDto user)
        {

            _dbService.Users.Add(user);
        }

        public ValueTask<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
