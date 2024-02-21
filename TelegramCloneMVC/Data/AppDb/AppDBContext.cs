using Microsoft.EntityFrameworkCore;
using TelegramCloneMVC.Data.Entities.Groups;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.Data.AppDb
{
    public partial class AppDBContext(DbContextOptions<AppDBContext> contextOptions)
                : DbContext(contextOptions)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(x => x.Id);
                
            });
            
            modelBuilder.Entity<GroupUsers>(entity =>
            {
                entity.HasOne(gu => gu.User)
                      .WithMany(u => u.GroupUsers)
                      .HasForeignKey(gu => gu.UserId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(gu => gu.Group)
                      .WithMany(g => g.GroupUsers)
                      .HasForeignKey(g => g.GroupId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserImages>(entity =>
            {
                entity.HasOne(ui => ui.User)
                      .WithMany(u => u.Images)
                      .HasForeignKey(ui => ui.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

        }
    }
}
