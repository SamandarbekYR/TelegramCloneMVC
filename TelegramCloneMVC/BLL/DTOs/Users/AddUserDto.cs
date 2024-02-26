using System.ComponentModel.DataAnnotations.Schema;
using TelegramCloneMVC.Data.Enums;

namespace TelegramCloneMVC.BLL.DTOs.Users
{
    public class AddUserDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string BIO { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public IFormFile Files { get; set; } 
    }
}
