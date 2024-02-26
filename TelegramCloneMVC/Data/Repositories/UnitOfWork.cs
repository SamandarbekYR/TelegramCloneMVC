using TelegramCloneMVC.Data.AppDb;
using TelegramCloneMVC.Data.Interfaces;
using TelegramCloneMVC.Data.Interfaces.Groups;
using TelegramCloneMVC.Data.Interfaces.Users;
using TelegramCloneMVC.Data.Repositories.Groups;
using TelegramCloneMVC.Data.Repositories.Users;

namespace TelegramCloneMVC.Data.Repositories
{
    public class UnitOfWork(AppDBContext appDB) : IUnitOfWork
    {
        public IUser Users => new UserRepository(appDB);
        public IUserImages Images => new UserImagesRepository(appDB);
        public IGroup Groups => new GroupRepository(appDB);
        public IGroupUsers GroupUsers => new GroupUsersRepository(appDB); 
    }
}
