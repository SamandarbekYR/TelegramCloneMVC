using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramCloneMVC.Data.Entities.Users
{
    [Table("users")]
    public class User: Auditable
    {
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;
        [Column("phone_number")]
        public string PhoneNumber {  get; set; } = string.Empty;
        [Column("bio")]
        public string BIO {  get; set; } = string.Empty;
        [Column("user_name")]
        public string UserName {  get; set; } = string.Empty;
    }
}
