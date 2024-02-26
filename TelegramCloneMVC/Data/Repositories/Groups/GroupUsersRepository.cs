using TelegramCloneMVC.Data.AppDb;
using TelegramCloneMVC.Data.Entities.Groups;
using TelegramCloneMVC.Data.Interfaces.Groups;

namespace TelegramCloneMVC.Data.Repositories.Groups
{
    public class GroupUsersRepository(AppDBContext appDB) 
                 : Repository<GroupUsers>(appDB) , IGroupUsers
    { }
}
