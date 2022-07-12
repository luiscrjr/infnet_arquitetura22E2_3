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

        public async Task<AlbumDto> Create(AlbumDto albumDto)
        {
            var album = mapper.Map<Domain.Album.Album>(albumDto);

            await albumRepository.Save(album);

            return mapper.Map<AlbumDto>(album);
        }


        public async Task<AlbumDto> Update(AlbumDto albumDto)
        {
            Domain.Album.Album album = null;
            var albumFromDb = await albumRepository.GetById(albumDto.Id);

            if (albumFromDb != null)
            {
                albumRepository.Detach(albumFromDb);
                album = mapper.Map<Domain.Album.Album>(albumDto);
                await albumRepository.Update(album);
            }

            return mapper.Map<AlbumDto>(album);
        }

        public async Task Delete(Guid albumId)
        {
            var album = await albumRepository.GetById(albumId);

            if (album == null)
                return;

            await albumRepository.Delete(album);
        }

        public async Task<ICollection<AlbumDto>> GetAll()
        {
            var albums = await albumRepository.GetAll();

            return mapper.Map<ICollection<AlbumDto>>(albums);
        }
    }
}
