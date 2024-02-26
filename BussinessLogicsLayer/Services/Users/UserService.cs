using AutoMapper;
using TelegramCloneMVC.BLL.DTOs.Users;
using TelegramCloneMVC.BLL.Interfaces.Users;
using TelegramCloneMVC.Data.Entities.Users;
using TelegramCloneMVC.Data.Interfaces;

namespace TelegramCloneMVC.BLL.Services.Users
{
    public class UserService(IUnitOfWork unitOfWork, IMapper mapper) : IUserService
    {
        public IUnitOfWork _dbService = unitOfWork;
        public IMapper _mapper = mapper;
       
        public async ValueTask<int> AddAsync(AddUserDto user)
        {
            User entity = _mapper.Map<User>(user);
            int result = await _dbService.Users.Add(entity);

            if (result > 0)
            {
                return result;
            }

            return 0;
        }

        public IEnumerable<User> GetAll()
        {
            return _dbService.Users.GetAll().ToList();
        }
    }
}
