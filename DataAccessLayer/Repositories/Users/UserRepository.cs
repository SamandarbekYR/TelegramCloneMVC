using TelegramCloneMVC.AppDb;
using TelegramCloneMVC.Entities;
using TelegramCloneMVC.Interfaces.Users;

namespace TelegramCloneMVC.Repositories.Users;

public class UserRepository(AppDBContext appDB) :
             Repository<User>(appDB), IUser
{ }
