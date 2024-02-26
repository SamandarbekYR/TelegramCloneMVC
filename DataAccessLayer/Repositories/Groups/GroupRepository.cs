using TelegramCloneMVC.AppDb;
using TelegramCloneMVC.Entities;
using TelegramCloneMVC.Interfaces.Groups;

namespace TelegramCloneMVC.Repositories.Groups;

public class GroupRepository(AppDBContext appDB) 
             : Repository<Group>(appDB) , IGroup
{ }
