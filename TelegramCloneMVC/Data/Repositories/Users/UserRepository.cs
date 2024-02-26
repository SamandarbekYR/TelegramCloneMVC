using TelegramCloneMVC.Data.AppDb;
using TelegramCloneMVC.Data.Entities.Users;
using TelegramCloneMVC.Data.Interfaces.Users;

namespace TelegramCloneMVC.Data.Repositories.Users
{
    public class UserRepository(AppDBContext appDB) : 
                 Repository<User>(appDB), IUser
    { }
}
