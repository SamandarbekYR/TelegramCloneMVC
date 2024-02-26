using AutoMapper;
using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.Data.Entities.Users;

namespace TelegramCloneMVC.BLL.Common.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<AddUserDto, User>().ReverseMap();
        }
    }
}
