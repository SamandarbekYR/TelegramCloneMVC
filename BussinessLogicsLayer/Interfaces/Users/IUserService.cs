using TelegramCloneMVC.DTOs.Users;
using TelegramCloneMVC.Entities;

public interface IUserService
{
    ValueTask<int> AddAsync(AddUserDto user);
    IEnumerable<User> GetAll();
}
