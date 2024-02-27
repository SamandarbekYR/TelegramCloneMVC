using AutoMapper;
using BusinessLogicsLayer.DTOs.Users;
using DataAccessLayer.Entities;

namespace BusinessLogicsLayer.Common.Mapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<AddUserDto, User>().ReverseMap();
    }
}
