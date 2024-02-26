using TelegramCloneMVC.Interfaces.Groups;
using TelegramCloneMVC.Interfaces.Users;

namespace TelegramCloneMVC.Interfaces
{
    public interface IUnitOfWork
    {
        public IUser Users { get; }
        public IUserImages Images { get; }
        public IGroup Groups { get; }
        public IGroupUsers GroupUsers { get;}
    }
}
