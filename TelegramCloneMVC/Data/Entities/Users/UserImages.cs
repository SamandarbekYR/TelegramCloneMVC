using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramCloneMVC.Data.Entities.Users
{
    [Table("user_images")]
    public class UserImages : BaseEntity
    {
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
    }
}
