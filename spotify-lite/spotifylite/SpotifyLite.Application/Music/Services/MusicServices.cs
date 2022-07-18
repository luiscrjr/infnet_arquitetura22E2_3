using AutoMapper;
using SpotifyLite.Application.Music.DTOs;
using SpotifyLite.Domain.Album.Repository;

namespace SpotifyLite.Application.Music.Services
{
    internal class MusicServices : IMusicServices
    {
        private readonly IMusicRepository musicRepository;
        private readonly IMapper mapper;

        public MusicServices(IMusicRepository musicRepository, IMapper mapper)
        {
            this.musicRepository = musicRepository;
            this.mapper = mapper;
        }

        public async Task<MusicOutputDto> Create(MusicInputDto musicDto)
        {
            var music = mapper.Map<Domain.Album.Music>(musicDto);

            await musicRepository.Save(music);

            return mapper.Map<MusicOutputDto>(music);
        }


        public async Task<MusicOutputDto> Update(MusicInputDto musicDto)
        {
            Domain.Album.Music music = null;
            var userFromDb = await musicRepository.GetById(musicDto.Id);

            if (userFromDb != null)
            {
                musicRepository.Detach(userFromDb);
                music = mapper.Map<Domain.Album.Music>(musicDto);
                await musicRepository.Update(music);
            }

            return mapper.Map<MusicOutputDto>(music);
        }

        public async Task Delete(Guid musicId)
        {
            var music = await musicRepository.GetById(musicId);
            await musicRepository.Delete(music);
        }

        public async Task<ICollection<MusicOutputDto>> GetAll()
        {
            var musics = await musicRepository.GetAll();

            return mapper.Map<ICollection<MusicOutputDto>>(musics);
        }
    }
}
