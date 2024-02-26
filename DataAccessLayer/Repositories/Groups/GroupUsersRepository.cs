using TelegramCloneMVC.AppDb;
using TelegramCloneMVC.Entities;
using TelegramCloneMVC.Interfaces.Groups;
using TelegramCloneMVC.Repositories;

namespace TelegramCloneMVC.Repositories.Groups;

public class GroupUsersRepository(AppDBContext appDB)
             : Repository<GroupUsers>(appDB), IGroupUsers
{ }
