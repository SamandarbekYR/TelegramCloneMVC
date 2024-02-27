using DataAccessLayer.AppDb;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces.Groups;

namespace DataAccessLayer.Repositories.Groups;

public class GroupRepository(AppDBContext appDB) 
             : Repository<Group>(appDB) , IGroup
{ }
