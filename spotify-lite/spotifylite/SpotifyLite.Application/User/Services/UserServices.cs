using AutoMapper;
using SpotifyLite.Application.User.DTOs;
using SpotifyLite.Domain.User.Repository;

namespace SpotifyLite.Application.User.Services
{
    internal class UserServices : IUserServices
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserServices(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<UserOutputDto> Create(UserInputDto userDto)
        {
            var user = mapper.Map<Domain.User.User>(userDto);

            await userRepository.Save(user);

            return mapper.Map<UserOutputDto>(user);
        }


        public async Task<UserOutputDto> Update(UserInputDto userDto)
        {
            Domain.User.User user = null;
            var userFromDb = await userRepository.GetById(userDto.Id);

            if (userFromDb != null)
            {
                userRepository.Detach(userFromDb);
                user = mapper.Map<Domain.User.User>(userDto);
                await userRepository.Update(user);
            }

            return mapper.Map<UserOutputDto>(user);
        }

        public async Task Delete(Guid userId)
        {
            var user = await userRepository.GetById(userId);
            await userRepository.Delete(user);
        }

        public async Task<ICollection<UserOutputDto>> GetAll()
        {
            var users = await userRepository.GetAll();

            return mapper.Map<ICollection<UserOutputDto>>(users);
        }
    }
}
