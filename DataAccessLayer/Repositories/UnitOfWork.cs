using TelegramCloneMVC.AppDb;
using TelegramCloneMVC.Interfaces;
using TelegramCloneMVC.Interfaces.Groups;
using TelegramCloneMVC.Interfaces.Users;
using TelegramCloneMVC.Repositories.Groups;
using TelegramCloneMVC.Repositories.Users;

namespace TelegramCloneMVC.Repositories;

public class UnitOfWork(AppDBContext appDB) : IUnitOfWork
{
    public IUser Users => new UserRepository(appDB);
    public IUserImages Images => new UserImagesRepository(appDB);
    public IGroup Groups => new GroupRepository(appDB);
    public IGroupUsers GroupUsers => new GroupUsersRepository(appDB);
}
