using DataAccessLayer.AppDb;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.Users;

namespace DataAccessLayer.Repositories.Users;

public class UserImagesRepository(AppDBContext appDB)
             : Repository<UserImages>(appDB), IUserImages
{ }
