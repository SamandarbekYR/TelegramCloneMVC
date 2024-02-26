using TelegramCloneMVC.AppDb;
using TelegramCloneMVC.Entities;
using TelegramCloneMVC.Interfaces.Users;
using TelegramCloneMVC.Repositories;

namespace TelegramCloneMVC.Repositories.Users;

public class UserImagesRepository(AppDBContext appDB)
             : Repository<UserImages>(appDB), IUserImages
{ }
