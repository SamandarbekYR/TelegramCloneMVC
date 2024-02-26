using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramCloneMVC.DTOs.Users;

namespace BusinessLogicsLayer.Interfaces.Auth
{
    public interface IAuth
    {
        ValueTask<int> Register(AddUserDto dto);
        ValueTask<int> LogIn(AddUserDto dto);
    }
}
