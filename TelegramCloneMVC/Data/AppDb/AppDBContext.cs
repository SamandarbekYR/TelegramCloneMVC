using Microsoft.EntityFrameworkCore;

namespace TelegramCloneMVC.Data.AppDb
{
    public partial class AppDBContext(DbContextOptions<AppDBContext> contextOptions)
                : DbContext(contextOptions)
    {
        
    }
}
