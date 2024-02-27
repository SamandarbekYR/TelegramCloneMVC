using DataAccessLayer.Interfaces.Groups;
using DataAccessLayer.Interfaces.Users;

namespace DataAccessLayer.Interfaces;

public interface IUnitOfWork
{
    public IUser Users { get; }
    public IUserImages Images { get; }
    public IGroup Groups { get; }
    public IGroupUsers GroupUsers { get;}
}
