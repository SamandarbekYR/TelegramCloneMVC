using TelegramCloneMVC.Data.Interfaces.Groups;
using TelegramCloneMVC.Data.Interfaces.Users;

namespace TelegramCloneMVC.Data.Interfaces
{
    public interface IUnitOfWork
    {
        public IUser Users { get; }
        public IUserImages Images { get; }
        public IGroup Groups { get; }
        public IGroupUsers GroupUsers { get;}
    }
}
