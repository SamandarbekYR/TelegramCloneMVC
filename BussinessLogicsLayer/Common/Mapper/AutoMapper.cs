

using AutoMapper;

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
