using System.ComponentModel.DataAnnotations.Schema;
using TelegramCloneMVC.Entities;

namespace DataAccessLayer.Entities;

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
    [Column("group_users")]
    public ICollection<GroupUsers> GroupUsers { get; set; } = new List<GroupUsers>();
}
