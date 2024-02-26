using TelegramCloneMVC.Data.AppDb;
using TelegramCloneMVC.Data.Entities.Groups;
using TelegramCloneMVC.Data.Interfaces.Groups;

namespace TelegramCloneMVC.Data.Repositories.Groups
{
    public class GroupRepository(AppDBContext appDB) 
                 : Repository<Group>(appDB) , IGroup
    { }
}
