using DataAccessLayer.AppDb;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.Groups;

namespace DataAccessLayer.Repositories.Groups;

public class GroupUsersRepository(AppDBContext appDB)
             : Repository<GroupUsers>(appDB), IGroupUsers
{ }
