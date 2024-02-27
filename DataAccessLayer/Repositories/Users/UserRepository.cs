using DataAccessLayer.AppDb;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.Users;

namespace DataAccessLayer.Repositories.Users;

public class UserRepository(AppDBContext appDB) :
             Repository<User>(appDB), IUser
{ }
