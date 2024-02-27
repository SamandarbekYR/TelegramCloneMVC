using DataAccessLayer.AppDb;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Interfaces.Groups;
using DataAccessLayer.Interfaces.Users;
using DataAccessLayer.Repositories.Groups;
using DataAccessLayer.Repositories.Users;

namespace DataAccessLayer.Repositories;

public class UnitOfWork(AppDBContext appDB) : IUnitOfWork
{
    public IUser Users => new UserRepository(appDB);
    public IUserImages Images => new UserImagesRepository(appDB);
    public IGroup Groups => new GroupRepository(appDB);
    public IGroupUsers GroupUsers => new GroupUsersRepository(appDB);
}
