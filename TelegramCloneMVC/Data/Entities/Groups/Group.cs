using System.ComponentModel.DataAnnotations.Schema;
using TelegramCloneMVC.Data.Enums;

namespace TelegramCloneMVC.Data.Entities.Groups
{
    [Table("group")]
    public class Group: Auditable
    {
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("bio")]
        public string BIO { get; set; } = string.Empty;
        [Column("image_path")]
        public string ImagePath { get; set; } = string.Empty;
        [Column("status")]
        public GroupStatus Status { get; set; }
        [Column("link")]
        public string Link { get; set; } = string.Empty;
    }
}
