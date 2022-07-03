using AutoMapper;
using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Domain.Album.Repository;

namespace SpotifyLite.Application.Album.Services
{
    internal class AlbumServices : IAlbumServices
    {
        private readonly IAlbumRepository albumRepository;
        private readonly IMapper mapper;

        public AlbumServices(IAlbumRepository albumRepository, IMapper mapper)
        {
            this.albumRepository = albumRepository;
            this.mapper = mapper;
        }

        public async Task<AlbumOutputDto> Create(AlbumInputDto albumInputDto)
        {
            var album = mapper.Map<Domain.Album.Album>(albumInputDto);

            await albumRepository.Save(album);

            return mapper.Map<AlbumOutputDto>(album);
        }


        public async Task<AlbumOutputDto> Update(AlbumInputDto albumInputDto)
        {
            var album = mapper.Map<Domain.Album.Album>(albumInputDto);

            await albumRepository.Update(album);

            return mapper.Map<AlbumOutputDto>(album);
        }

        public async Task Delete(AlbumInputDto albumInputDto)
        {
            var album = mapper.Map<Domain.Album.Album>(albumInputDto);

            await albumRepository.Delete(album);
        }

        public async Task<ICollection<AlbumOutputDto>> GetAll()
        {
            var albums = await albumRepository.GetAll();

            return mapper.Map<ICollection<AlbumOutputDto>>(albums);
        }
    }
}
