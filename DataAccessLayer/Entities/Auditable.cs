using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities;

public class Auditable:BaseEntity
{
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set;}
}
