using System.ComponentModel.DataAnnotations.Schema;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.Data.Entities.Groups
{
    [Table("group_users")]
    public class GroupUsers : BaseEntity
    {
        [Column("group_id")]
        public Guid GroupId { get; set; }
        public Group Group { get; set; } = new();
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = new();
    }
}
