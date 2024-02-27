using AutoMapper;
using DataAccessLayer.Entities;

namespace BusinessLogicsLayer.Common.Mapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<AddUserDto, User>().ReverseMap();
    }
}
