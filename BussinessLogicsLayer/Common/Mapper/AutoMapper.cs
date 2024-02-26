

using AutoMapper;
using TelegramCloneMVC.DTOs.Users;
using TelegramCloneMVC.Entities;

namespace TelegramCloneMVC.Common.Mapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<AddUserDto, User>().ReverseMap();
    }
}
